using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Tiff;
using Vintasoft.Imaging.ColorManagement;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.Print;
using Vintasoft.Imaging.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.ColorManagement;
using DemosCommonCode.Imaging;

namespace PrintDemo
{
    /// <summary>
    /// Main form of Print Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Customized image print document.
        /// </summary>
        CustomImagePrintDocument _imagePrintDocument;

        /// <summary>
        /// A value indicating whether the single page is printed.
        /// </summary>
        bool _isSinglePagePrinting = false;

        /// <summary>
        /// Printing image.
        /// </summary>
        VintasoftImage _printingImage = null;

        /// <summary>
        /// A value indicating whether the image should be disposed after print.
        /// </summary>
        bool _disposePrintingImageAfterPrint;

        /// <summary>
        /// Index, in image collection of the thumbnail viewer, of printing image.
        /// </summary>
        int _printingImageIndex;

        /// <summary>
        /// Indexes of first pages of the images.
        /// </summary>
        int[] _indexesOfFirstPagesOfImages;

        /// <summary>
        /// Count of pages in PrintPreviewControl.
        /// </summary>
        int _pageCount;

        /// <summary>
        /// A value indicating whether the value of PageIndexNumericUpDown is changed.
        /// </summary>
        bool _isPageIndexNumericUpDownValueChanged;

        /// <summary>
        /// Color management settings of printing images.
        /// </summary>
        ColorManagementDecodeSettings _printColorManagement;

        /// <summary>
        /// Manages the layout settings of DOCX document image collections.
        /// </summary>
        ImageCollectionDocxLayoutSettingsManager _imageCollectionDocxLayoutSettingsManager;

        /// <summary>
        /// Manages the layout settings of XLSX document image collections.
        /// </summary>
        ImageCollectionXlsxLayoutSettingsManager _imageCollectionXlsxLayoutSettingsManager;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            Jbig2AssemblyLoader.Load();
            Jpeg2000AssemblyLoader.Load();
            RawAssemblyLoader.Load();
            DicomAssemblyLoader.Load();
            DocxAssemblyLoader.Load();

            _imagePrintDocument = new CustomImagePrintDocument(thumbnailViewer1.AnnotationDataController);
            _imagePrintDocument.Center = false;
            _imagePrintDocument.DefaultDistanceBetweenImages = 10;
            _imagePrintDocument.PrintScaleMode = PrintScaleMode.None;
            _imagePrintDocument.BeginPrint += new PrintEventHandler(imagePrintDocument_BeginPrint);
            _imagePrintDocument.PrintImage += new EventHandler<PrintImageEventArgs>(imagePrintDocument_PrintImage);
            _imagePrintDocument.EndPrint += new PrintEventHandler(imagePrintDocument_EndPrint);
            _imagePrintDocument.PrintPage += new PrintPageEventHandler(imagePrintDocument_PrintPage);
            _imagePrintDocument.PrintingException += new EventHandler<ExceptionEventArgs>(imagePrintDocument_PrintingException);

            this.printPreviewControl1.Document = _imagePrintDocument;
            this.pageSetupDialog1.Document = _imagePrintDocument;
            this.printDialog1.Document = _imagePrintDocument;

            this.Text = string.Format("VintaSoft Print Demo v{0}", ImagingGlobalSettings.ProductVersion);

            scaleModeComboBox.Items.Add(PrintScaleMode.None);
            scaleModeComboBox.Items.Add(PrintScaleMode.BestFit);
            scaleModeComboBox.Items.Add(PrintScaleMode.FitToHeight);
            scaleModeComboBox.Items.Add(PrintScaleMode.FitToWidth);
            scaleModeComboBox.Items.Add(PrintScaleMode.Mosaic);
            scaleModeComboBox.Items.Add(PrintScaleMode.CropToPageSize);
            scaleModeComboBox.Items.Add(PrintScaleMode.Stretch);
            scaleModeComboBox.SelectedItem = PrintScaleMode.BestFit;

            // set filters in open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openFileDialog1);

            // set the initial directory in open file dialog
            DemosTools.SetTestFilesFolder(openFileDialog1);

            thumbnailViewer1.Images.ImageCollectionChanged += new EventHandler<ImageCollectionChangeEventArgs>(thumbnailViewer1_Images_ImageCollectionChanged);
            thumbnailViewer1.AnnotationDataController.AnnotationDataDeserializationException += new EventHandler<Vintasoft.Imaging.Annotation.AnnotationDataDeserializationExceptionEventArgs>(thumbnailViewer1_AnnotationDataController_AnnotationDataDeserializationException);

            // set CustomFontProgramsController for all opened documents
            CustomFontProgramsController.SetDefaultFontProgramsController();

            DocumentPasswordForm.EnableAuthentication(thumbnailViewer1);

#if !REMOVE_OFFICE_PLUGIN
            // specify image collection of thumbnail viewer must handle layout settings requests
            _imageCollectionDocxLayoutSettingsManager = new ImageCollectionDocxLayoutSettingsManager(thumbnailViewer1.Images);
            _imageCollectionXlsxLayoutSettingsManager = new ImageCollectionXlsxLayoutSettingsManager(thumbnailViewer1.Images);
#else
            documentLayoutSettingsToolStripMenuItem.Visible = false;
#endif

            // initialize color management in viewer
            ColorManagementHelper.EnableColorManagement(thumbnailViewer1);

            imageAutoOrientationCheckBox.Checked = _imagePrintDocument.UseImageAutoOrienation;

            // update the UI
            UpdateUI();
        }



        #endregion



        #region Properties

        bool _isFileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether file is opening.
        /// </summary>
        bool IsFileOpening
        {
            get
            {
                return _isFileOpening;
            }
            set
            {
                _isFileOpening = value;
                UpdateUI();
            }
        }

        bool _isFilePrinting = false;
        /// <summary>
        /// Gets or sets a value indicating whether file is printing.
        /// </summary>
        bool IsFilePrinting
        {
            get
            {
                return _isFilePrinting;
            }
            set
            {
                _isFilePrinting = value;
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Application form is closing.
        /// </summary>
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            thumbnailViewer1.Images.Dispose();
        }

        #endregion


        #region PRIVATE

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of OpenToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFileOpening = true;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (thumbnailViewer1.Images.Count > 0)
                    {
                        // clear image collection of thumbnail viewer
                        thumbnailViewer1.Images.ClearAndDisposeItems();
                    }

                    // add new image(s) to thumbnail viewer image collection
                    thumbnailViewer1.Images.Add(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }

            IsFileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of AddToolStripMenuItem object.
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFileOpening = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // add image(s) to image collection of thumbnail viewer
                thumbnailViewer1.Images.Add(openFileDialog1.FileName);
            }

            IsFileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of DocxLayoutSettingsToolStripMenuItem object.
        /// </summary>
        private void docxLayoutSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _imageCollectionDocxLayoutSettingsManager.EditLayoutSettingsUseDialog();
        }

        /// <summary>
        /// Handles the Click event of XlsxLayoutSettingsToolStripMenuItem object.
        /// </summary>
        private void xlsxLayoutSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _imageCollectionXlsxLayoutSettingsManager.EditLayoutSettingsUseDialog();
        }

        /// <summary>
        /// Handles the Click event of PageSettingsToolStripMenuItem object.
        /// </summary>
        private void pageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show dialog with page settings
            pageSetupDialog1.ShowDialog();

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the Click event of PrintColorManagementToolStripMenuItem object.
        /// </summary>
        private void printColorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // edit print color management settings
            EditPrintColorManagement();
        }

        /// <summary>
        /// Handles the Click event of PrintToolStripMenuItem object.
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsFilePrinting = true;

            // check whether selection is not empty
            printDialog1.AllowSelection = thumbnailViewer1.SelectedIndices.Count > 0;

            // show print dialog
            System.Windows.Forms.DialogResult dialogResult = printDialog1.ShowDialog();

            // PrintDialog control has bug and sometimes does not show print dialog and returns
            // Cancel as a result of execution of the ShowDialog method. This problem can be solved
            // if you will set the UseEXDialog property to True.
            if (dialogResult == System.Windows.Forms.DialogResult.Cancel &&
                printDialog1.UseEXDialog == false)
            {
                printDialog1.UseEXDialog = true;
                dialogResult = printDialog1.ShowDialog();
            }

            // start print if dialog results is OK
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _imagePrintDocument.Print();
            }

            IsFilePrinting = false;
        }

        /// <summary>
        /// Handles the Click event of ExitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of ColorManagementToolStripMenuItem object.
        /// </summary>
        private void colorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool previewColorManagementIsNull = thumbnailViewer1.ImageDecodingSettings == null ||
                thumbnailViewer1.ImageDecodingSettings.ColorManagement == null;
            if (ColorManagementSettingsForm.EditColorManagement(thumbnailViewer1))
            {
                // if color management settings could be changed
                if (!previewColorManagementIsNull ||
                    (thumbnailViewer1.ImageDecodingSettings != null &&
                    thumbnailViewer1.ImageDecodingSettings.ColorManagement != null))
                {
                    // reload preview
                    printPreviewControl1.InvalidatePreview();
                }
            }
        }

        #endregion


        #region 'Page' menu

        /// <summary>
        /// Handles the Click event of ShowPageHeaderToolStripMenuItem object.
        /// </summary>
        private void showPageHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPageHeaderToolStripMenuItem.Checked = !showPageHeaderToolStripMenuItem.Checked;
            // enable/disable page header display
            _imagePrintDocument.ShowPageHeader = showPageHeaderToolStripMenuItem.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the Click event of ShowPageFooterToolStripMenuItem object.
        /// </summary>
        private void showPageFooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPageFooterToolStripMenuItem.Checked = !showPageFooterToolStripMenuItem.Checked;
            // enable/disable page footer display
            _imagePrintDocument.ShowPageFooter = showPageFooterToolStripMenuItem.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the Click event of ShowImageHeaderToolStripMenuItem object.
        /// </summary>
        private void showImageHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showImageHeaderToolStripMenuItem.Checked = !showImageHeaderToolStripMenuItem.Checked;
            // enable/disable image header display
            _imagePrintDocument.ShowImageHeader = showImageHeaderToolStripMenuItem.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the Click event of ShowImageFooterToolStripMenuItem object.
        /// </summary>
        private void showImageFooterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showImageFooterToolStripMenuItem.Checked = !showImageFooterToolStripMenuItem.Checked;
            // enable/disable image footer display
            _imagePrintDocument.ShowImageFooter = showImageFooterToolStripMenuItem.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the Click event of ShowImageRectToolStripMenuItem object.
        /// </summary>
        private void showImageRectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showImageRectToolStripMenuItem.Checked = !showImageRectToolStripMenuItem.Checked;
            // enable/disable image rectangle display
            _imagePrintDocument.ShowImageRect = showImageRectToolStripMenuItem.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of AboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region Context menu

        /// <summary>
        /// Handles the Click event of PrintImageMenuItem object.
        /// </summary>
        private void printImageMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = printDialog1.ShowDialog();

            // PrintDialog control has bug and sometimes does not show print dialog and returns
            // Cancel as a result of execution of the ShowDialog method. This problem can be solved
            // if you will set the UseEXDialog property to True.
            if (dialogResult == System.Windows.Forms.DialogResult.Cancel &&
                printDialog1.UseEXDialog == false)
            {
                printDialog1.UseEXDialog = true;
                dialogResult = printDialog1.ShowDialog();
            }

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _isSinglePagePrinting = true;

                PrintScaleMode mode = _imagePrintDocument.PrintScaleMode;
                _imagePrintDocument.PrintScaleMode = PrintScaleMode.BestFit;
                _imagePrintDocument.Print();
                _imagePrintDocument.PrintScaleMode = mode;
            }
        }

        #endregion


        #region Print settings

        /// <summary>
        /// Handles the SelectedValueChanged event of ScaleModeComboBox object.
        /// </summary>
        private void scaleModeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // get selected scale mode
            PrintScaleMode newPrintScaleMode = (PrintScaleMode)scaleModeComboBox.SelectedItem;
            if (_imagePrintDocument.PrintScaleMode != newPrintScaleMode)
            {
                _imagePrintDocument.PrintScaleMode = newPrintScaleMode;

                imagesPerPageGroupBox.Enabled = newPrintScaleMode == PrintScaleMode.Mosaic;

                centerImageOnPageCheckBox.Enabled = newPrintScaleMode == PrintScaleMode.CropToPageSize ||
                    newPrintScaleMode == PrintScaleMode.BestFit;

                // update the UI
                UpdateUI();

                printPreviewControl1.InvalidatePreview();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of CenterImageOnPageCheckBox object.
        /// </summary>
        private void centerImageOnPageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // enable/disable centering of image on page
            _imagePrintDocument.Center = centerImageOnPageCheckBox.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the CheckedChanged event of ImageAutoOrientationCheckBox object.
        /// </summary>
        private void imageAutoOrientationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // enable/disable centering of image on page
            _imagePrintDocument.UseImageAutoOrienation = imageAutoOrientationCheckBox.Checked;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the CheckedChanged event of PrintImageWithAnnotationsCheckBox object.
        /// </summary>
        private void printImageWithAnnotationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_imagePrintDocument == null)
                return;

            // enable/disable image printing with annotations
            bool printAnnotations = printImageWithAnnotationsCheckBox.Checked;
            thumbnailViewer1.ShowAnnotations = printAnnotations;
            _imagePrintDocument.PrintAnnotations = printAnnotations;

            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the ValueChanged event of ColumnsOnPageNumericUpDown object.
        /// </summary>
        private void columnsOnPageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_imagePrintDocument == null)
                return;

            // change the number of columns per page
            _imagePrintDocument.MosaicColumnCount = (int)columnsOnPageNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of RowsOnPageNumericUpDown object.
        /// </summary>
        private void rowsOnPageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_imagePrintDocument == null)
                return;

            // change the number of rows per page
            _imagePrintDocument.MosaicRowCount = (int)rowsOnPageNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the Click event of ImagesPerPageUpdateButton object.
        /// </summary>
        private void imagesPerPageUpdateButton_Click(object sender, EventArgs e)
        {
            // update the number of columns and rows per page
            printPreviewControl1.InvalidatePreview();
        }

        #endregion


        #region Thumbnail viewer

        /// <summary>
        /// Handles the ImageCollectionChanged event of Images property of ThumbnailViewer1 object.
        /// </summary>
        private void thumbnailViewer1_Images_ImageCollectionChanged(object sender, ImageCollectionChangeEventArgs e)
        {
            printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Handles the AnnotationDataDeserializationException event of AnnotationDataController property of ThumbnailViewer1 object.
        /// </summary>
        private void thumbnailViewer1_AnnotationDataController_AnnotationDataDeserializationException(object sender, Vintasoft.Imaging.Annotation.AnnotationDataDeserializationExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage("AnnotationData deserialization exception", e.Exception);
        }

        /// <summary>
        /// Handles the FocusedIndexChanged event of ThumbnailViewer1 object.
        /// </summary>
        private void thumbnailViewer1_FocusedIndexChanged(object sender, FocusedIndexChangedEventArgs e)
        {
            if (_indexesOfFirstPagesOfImages == null)
                return;

            if (e.FocusedIndex == -1)
            {
                pageIndexNumericUpDown.Value = 0;
            }
            else
            {
                pageIndexNumericUpDown.Value = _indexesOfFirstPagesOfImages[e.FocusedIndex];
            }
        }

        #endregion


        #region Print preview control

        /// <summary>
        /// Handles the StartPageChanged event of PrintPreviewControl1 object.
        /// </summary>
        private void printPreviewControl1_StartPageChanged(object sender, EventArgs e)
        {
            if (_isPageIndexNumericUpDownValueChanged)
                return;

            // update value on control
            pageIndexNumericUpDown.Value = this.printPreviewControl1.StartPage;
        }

        /// <summary>
        /// Handles the ValueChanged event of ZoomTrackBar object.
        /// </summary>
        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // update value on control
            printPreviewControl1.Zoom = (float)zoomTrackBar.Value / 100f;
            toolTip1.SetToolTip(zoomTrackBar, zoomTrackBar.Value.ToString() + "%");
        }

        /// <summary>
        /// Handles the ValueChanged event of PageIndexNumericUpDown object.
        /// </summary>
        private void pageIndexNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _isPageIndexNumericUpDownValueChanged = true;

            // update value on control
            this.printPreviewControl1.StartPage = (int)this.pageIndexNumericUpDown.Value;

            _isPageIndexNumericUpDownValueChanged = false;
        }

        /// <summary>
        /// Handles the ValueChanged event of VisibleColumnCountNumericUpDown object.
        /// </summary>
        private void visibleColumnCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // update the number of visible columns
            printPreviewControl1.Columns = (int)visibleColumnCountNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the ValueChanged event of VisibleRowCountNumericUpDown object.
        /// </summary>
        private void visibleRowCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // update the number of visible rows
            printPreviewControl1.Rows = (int)visibleRowCountNumericUpDown.Value;
        }

        #endregion

        #endregion


        #region UI state

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            // get the current status of application
            bool isFileOpening = IsFileOpening;
            bool isFileLoaded = thumbnailViewer1.Images != null;
            bool isFileEmpty = true;
            if (isFileLoaded)
                isFileEmpty = thumbnailViewer1.Images.Count == 0;
            bool isFilePrinting = IsFilePrinting;

            // "File" menu
            fileToolStripMenuItem.Enabled = !isFileOpening && !isFilePrinting;
            pageSettingsToolStripMenuItem.Enabled = !isFileEmpty;
            printToolStripMenuItem.Enabled = !isFileEmpty;

            // "Page" menu
            pageToolStripMenuItem.Enabled = !isFileOpening && !isFilePrinting && !isFileEmpty;

            // all controls
            panel1.Enabled = !isFileOpening && !isFilePrinting && !isFileEmpty;

            imageAutoOrientationCheckBox.Enabled = _imagePrintDocument.PrintScaleMode == PrintScaleMode.BestFit;
        }

        #endregion


        #region Print

        /// <summary>
        /// Handler of the print start event.
        /// </summary>
        private void imagePrintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (thumbnailViewer1.Images.Count == 0)
                e.Cancel = true;

            // init index of printing image
            if (_isSinglePagePrinting)
                _printingImageIndex = thumbnailViewer1.FocusedIndex;
            else
                _printingImageIndex = _imagePrintDocument.PrinterSettings.FromPage - 1;

            if (_printingImageIndex == -1)
                _printingImageIndex = 0;

            // if controller in the preview mode
            if (((ImagePrintDocument)sender).PrintController.IsPreview)
            {
                // init an array of indexes of first pages of images

                if (thumbnailViewer1.Images.Count == 0)
                    _indexesOfFirstPagesOfImages = null;
                else
                    _indexesOfFirstPagesOfImages = new int[thumbnailViewer1.Images.Count];
            }

            _pageCount = 0;
        }

        /// <summary>
        /// Handler of the page print event.
        /// </summary>
        private void imagePrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            _pageCount++;
        }

        /// <summary>
        /// Handler of the image print event.
        /// </summary>
        private void imagePrintDocument_PrintImage(object sender, PrintImageEventArgs e)
        {
            // dispose previously printed image if neccessary
            if (_printingImage != null && _disposePrintingImageAfterPrint)
            {
                _printingImage.Dispose();
                _printingImage = null;
            }

            int printingImageIndex = _printingImageIndex;
            int lastPageNumber = thumbnailViewer1.Images.Count;

            bool isPreview = ((ImagePrintDocument)sender).PrintController.IsPreview;

            // if the application in a preview mode
            if (isPreview)
            {
                // set the index of the first page of printing image
                _indexesOfFirstPagesOfImages[_printingImageIndex] = _imagePrintDocument.PrintedPageCount;
            }
            // if the application in a print mode
            else
            {
                // if printing from context menu of the thumbnail
                if (_isSinglePagePrinting)
                {
                    _isSinglePagePrinting = false;
                    lastPageNumber = 1;
                }
                // if printing using print dialog
                else
                {
                    // if SomePages mode is used
                    if (_imagePrintDocument.PrinterSettings.PrintRange == PrintRange.SomePages)
                        lastPageNumber = Math.Min(lastPageNumber, _imagePrintDocument.PrinterSettings.ToPage);

                    // if Selection mode is used
                    else if (_imagePrintDocument.PrinterSettings.PrintRange == PrintRange.Selection)
                    {
                        if (thumbnailViewer1.SelectedIndices.Count > 0)
                        {
                            lastPageNumber = thumbnailViewer1.SelectedIndices.Count;

                            printingImageIndex = thumbnailViewer1.SelectedIndices[_printingImageIndex];
                        }
                    }
                }
            }

            // get the image which must be printed at the moment
            _printingImage = GetPrintingImage(printingImageIndex, isPreview, out _disposePrintingImageAfterPrint);

            // set image to print
            e.Image = _printingImage;

            // increment index of printed image
            _printingImageIndex++;

            // determine if there is more images to print
            e.HasMoreImages = _printingImageIndex < lastPageNumber;
        }

        /// <summary>
        /// Handler of the print finish event.
        /// </summary>
        private void imagePrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            // dispose last printed image if neccessary
            if (_printingImage != null && _disposePrintingImageAfterPrint)
            {
                _printingImage.Dispose();
                _printingImage = null;
            }

            //
            if (_pageCount == 0)
                pageIndexNumericUpDown.Maximum = 0;
            else
                pageIndexNumericUpDown.Maximum = _pageCount - 1;
        }

        /// <summary>
        /// Handler of the print exception event.
        /// </summary>
        private void imagePrintDocument_PrintingException(object sender, ExceptionEventArgs e)
        {
            DemosTools.ShowErrorMessage("Printing exception", e.Exception);
        }

        /// <summary>
        /// Returns an image that is currently being printed.
        /// </summary>
        private VintasoftImage GetPrintingImage(int pageIndex, bool isPreview, out bool disposePrintingImageAfterPrint)
        {
            disposePrintingImageAfterPrint = false;

            try
            {
                VintasoftImage printingImage = thumbnailViewer1.Images[pageIndex];

                // if the application in a print mode
                if (!isPreview)
                {
                    // if image is not virtual and it is not changed
                    if (printingImage.SourceInfo.SourceType != ImageSourceType.Image && !printingImage.IsChanged)
                    {
                        // if image is not already cloned
                        if (!disposePrintingImageAfterPrint)
                        {
                            // create image's clone based on same decoder
                            printingImage = VintasoftImage.CreateImageBasedOnSourceImageDecoder(printingImage);
                            disposePrintingImageAfterPrint = true;
                        }

                        SetColorManagement(printingImage, _printColorManagement);
                    }
                }

                return printingImage;
            }
            catch (TiffFileException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ImageProcessingException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Edits a color management settings of printing images.
        /// </summary>
        private void EditPrintColorManagement()
        {
            using (ColorManagementSettingsForm colorManagementSettingsForm = new ColorManagementSettingsForm())
            {
                colorManagementSettingsForm.ColorManagementSettings = _printColorManagement;

                if (colorManagementSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _printColorManagement = colorManagementSettingsForm.ColorManagementSettings;
                }
            }
        }

        /// <summary>
        /// Sets a color management settings for specified image.
        /// </summary>
        /// <param name="image">Image to set color management.</param>
        /// <param name="colorManagementSettings">Color management settings.</param>
        private void SetColorManagement(VintasoftImage image, ColorManagementDecodeSettings colorManagementSettings)
        {
            if (colorManagementSettings != null && image.DecodingSettings == null)
                image.DecodingSettings = new DecodingSettings();

            if (image.DecodingSettings != null)
                image.DecodingSettings.ColorManagement = colorManagementSettings;
        }

        #endregion

        #endregion

        #endregion

     
    }
}
