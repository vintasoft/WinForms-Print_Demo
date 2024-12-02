using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Annotation;
#if REMOVE_PDF_PLUGIN
using Vintasoft.Imaging.Annotation.Print;
#else
using Vintasoft.Imaging.Annotation.Pdf.Print;
#endif

namespace PrintDemo
{
    /// <summary>
    /// Shows how to print images with annotations
    /// and optionally adds an additional text at headers and footers of pages and images.
    /// </summary>
#if REMOVE_PDF_PLUGIN
    public class CustomImagePrintDocument : AnnotatedImagePrintDocument
#if FALSE
    {}
#endif
#else
    public class CustomImagePrintDocument : AnnotatedPdfPrintDocument
#endif
    {

        #region Constants

        /// <summary>
        /// Page/image header/footer height, in 1/100 of inch.
        /// </summary>
        const int HeaderFooterHeight = 52;

        #endregion



        #region Fields

        /// <summary>
        /// The page margins specified by user.
        /// </summary>
        Margins _userPageMargins;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomImagePrintDocument"/> class.
        /// </summary>
        public CustomImagePrintDocument()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomImagePrintDocument"/> class.
        /// </summary>
        /// <param name="annotationDataController">The annotation data controller.</param>
        public CustomImagePrintDocument(AnnotationDataController annotationDataController)
            : base(annotationDataController)
        {
        }

        #endregion



        #region Properties

        bool _showPageHeader;
        /// <summary>
        /// Gets or sets a value indicating whether the page header is shown.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowPageHeader
        {
            get
            {
                return _showPageHeader;
            }
            set
            {
                _showPageHeader = value;
            }
        }

        bool _showPageFooter;
        /// <summary>
        /// Gets or sets a value indicating whether the page footer is shown.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowPageFooter
        {
            get
            {
                return _showPageFooter;
            }
            set
            {
                _showPageFooter = value;
            }
        }

        bool _showImageHeader;
        /// <summary>
        /// Gets or sets a value indicating whether the image header is shown.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowImageHeader
        {
            get
            {
                return _showImageHeader;
            }
            set
            {
                _showImageHeader = value;
            }
        }

        bool _showImageFooter;
        /// <summary>
        /// Gets or sets a value indicating whether the image footer is shown.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowImageFooter
        {
            get
            {
                return _showImageFooter;
            }
            set
            {
                _showImageFooter = value;
            }
        }

        bool _showImageRect;
        /// <summary>
        /// Gets or sets a value indicating whether the image rect is shown.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowImageRect
        {
            get
            {
                return _showImageRect;
            }
            set
            {
                _showImageRect = value;
            }
        }

        int _defaultDistanceBetweenImages = 5;
        /// <summary>
        /// Gets or sets default space between images, in hundredths of an inch.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DefaultDistanceBetweenImages
        {
            get
            {
                return _defaultDistanceBetweenImages;
            }
            set
            {
                if (value < 0)
                    _defaultDistanceBetweenImages = 0;
                else
                    _defaultDistanceBetweenImages = value;
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Raises the <see cref="E:System.Drawing.Printing.PrintDocument.QueryPageSettings" /> event.
        /// It is called immediately before each
        /// <see cref="E:System.Drawing.Printing.PrintDocument.PrintPage" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Drawing.Printing.QueryPageSettingsEventArgs" /> that
        /// contains the event data.</param>
        protected override void OnQueryPageSettings(QueryPageSettingsEventArgs e)
        {
            DistanceBetweenImages = DefaultDistanceBetweenImages;
            // if image header or image footer must be shown
            if (ShowImageHeader || ShowImageFooter)
            {
                // if print scale mode is Mosaic
                if (PrintScaleMode == Vintasoft.Imaging.Print.PrintScaleMode.Mosaic)
                {
                    if (MosaicColumnCount == 1)
                        DistanceBetweenImages += 60;
                    else if (MosaicColumnCount == 2)
                        DistanceBetweenImages += 40;
                    else
                        DistanceBetweenImages += 20;
                }
                else
                {
                    DistanceBetweenImages += 70;
                }
            }

            if (_userPageMargins != null && e.PageSettings.Margins != _userPageMargins)
                e.PageSettings.Margins = _userPageMargins;

            base.OnQueryPageSettings(e);

            _userPageMargins = e.PageSettings.Margins;
            SetNewPageMargins(e.PageSettings);
        }

        /// <summary>
        /// Raises the <see cref="PrintDocument.PrintPage" /> event. It is called before a page prints.
        /// </summary>
        /// <param name="e">A <see cref="PrintPageEventArgs" /> that contains the event data.</param>
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            // if page header should be shown
            if (ShowPageHeader)
            {
                int headerXPos = e.MarginBounds.X;
                int headerYPos = e.MarginBounds.Y - HeaderFooterHeight;
                if (ShowImageHeader)
                    headerYPos -= HeaderFooterHeight;
                if (headerYPos < 0)
                    headerYPos = 0;

                string printText = string.Format(
                    "Page: {0}; Scale mode: {1}",
                    PrintedPageCount,
                    PrintScaleMode);
                // draw image header on the image
                e.Graphics.DrawString(printText, new Font(FontFamily.GenericSerif, 20),
                    Brushes.Black, new PointF(headerXPos, headerYPos));
            }

            // if page footer should be shown
            if (ShowPageFooter)
            {
                int footerXPos = e.MarginBounds.X;
                int footerYPos = e.MarginBounds.Y + e.MarginBounds.Height;
                if (ShowImageFooter)
                    footerYPos += HeaderFooterHeight;

                string printText = string.Format("{0}", DateTime.Now);
                // draw image header on the image
                e.Graphics.DrawString(printText, new Font(FontFamily.GenericSerif, 20),
                    Brushes.Black, new PointF(footerXPos, footerYPos));
            }
        }

        /// <summary>
        /// Draws the specified rectangular area of <see cref="VintasoftImage" /> on
        /// the specified rectangular area of page's <see cref="System.Drawing.Graphics" />.
        /// </summary>
        /// <param name="image">Image to draw.</param>
        /// <param name="graphics">Page's graphics, where image should be drawn.</param>
        /// <param name="sourceRect">The rectangular area, in device-independent pixels (1/96th inch),
        /// of image to draw.</param>
        /// <param name="destRect">The rectangular area, in pixels, of page's graphics
        /// where image should be drawn.</param>
        /// <param name="printerResolutionX">The resolution of printer along X-axis.</param>
        /// <param name="printerResolutionY">The resolution of printer along Y-axis.</param>
        /// <param name="landscape">Determines that need drw image in landscape.</param>
        protected override void DrawImage(
            VintasoftImage image,
            Graphics graphics,
            RectangleF sourceRect,
            RectangleF destRect,
            float printerResolutionX,
            float printerResolutionY, 
            bool landscape)
        {
            // used font family
            FontFamily fontFamily = FontFamily.GenericSerif;

            string headerText = string.Empty;
            Font headerFont = null;
            PointF headerStartPoint = PointF.Empty;

            string footerText = string.Empty;
            Font footerFont = null;
            PointF footerStartPoint = PointF.Empty;

            // if image header must be shown
            if (ShowImageHeader)
            {
                // if print scale mode is Mosaic
                if (PrintScaleMode == Vintasoft.Imaging.Print.PrintScaleMode.Mosaic)
                {
                    // get image filename and page index
                    headerText = string.Format(
                        "{0}, {1}",
                        Path.GetFileName(image.SourceInfo.Filename),
                        image.SourceInfo.PageIndex);
                }
                // if print scale mode is not Mosaic
                else
                {
                    // get image filename and page index
                    headerText = string.Format(
                        "Filename: {0}, Page index: {1}",
                        Path.GetFileName(image.SourceInfo.Filename),
                        image.SourceInfo.PageIndex);
                }

                // get font size
                float fontSize = CalculateFontSize(headerText, fontFamily, destRect.Width, graphics);
                // get font
                headerFont = new Font(fontFamily, fontSize);
                // get text size
                SizeF textSize = graphics.MeasureString(headerText, headerFont);

                // get start position of the image header
                float headerXPos = destRect.X;
                float headerYPos = destRect.Y - textSize.Height;
                if (headerYPos < 0)
                    headerYPos = 0;
                headerStartPoint = new PointF(headerXPos, headerYPos);
            }

            // if image footer must be shown
            if (ShowImageFooter)
            {
                // get image info
                footerText = string.Format(
                    "Image info: {0}x{1} px, {2}, {3}",
                    image.Width,
                    image.Height,
                    image.PixelFormat,
                    image.Resolution);

                // get font size
                float fontSize = CalculateFontSize(footerText, fontFamily, destRect.Width, graphics);
                // get font
                footerFont = new Font(fontFamily, fontSize);
                // get text size
                SizeF textSize = graphics.MeasureString(footerText, footerFont);

                // get start position of the image footer
                float footerXPos = destRect.X;
                float footerYPos = destRect.Y + destRect.Height;
                footerStartPoint = new PointF(footerXPos, footerYPos);
            }

            // draw image
            base.DrawImage(image, graphics, sourceRect, destRect, printerResolutionX, printerResolutionY, landscape);
            if (ShowImageHeader)
            {
                // draw image header
                graphics.DrawString(headerText, headerFont,
                    Brushes.Black, headerStartPoint);
                
                headerFont.Dispose();
            }
            if (ShowImageFooter)
            {
                // draw image footer
                graphics.DrawString(footerText, footerFont,
                    Brushes.Black, footerStartPoint);

                footerFont.Dispose();
            }

            // if image rect must be shown
            if (ShowImageRect)
            {
                // draw image rect
                using (Pen pen = new Pen(Color.Lime, 30))
                    graphics.DrawRectangle(pen, destRect.X, destRect.Y, destRect.Width, destRect.Height);
            }
        }

        /// <summary>
        /// Raises the <see cref="PrintDocument.EndPrint" /> event.
        /// It is called when the last page of the document has printed.
        /// </summary>
        /// <param name="e">A <see cref="PrintEventArgs" /> that contains the event data.</param>
        protected override void OnEndPrint(PrintEventArgs e)
        {
            base.OnEndPrint(e);

            _userPageMargins = null;
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Calculates the font size, which must be used for drawing the specified text in specified rectangle.
        /// </summary>
        /// <param name="text">The text string.</param>
        /// <param name="fontFamily">The text font family.</param>
        /// <param name="maxWidth">The maximum width of the text.</param>
        /// <param name="g">Page's graphics, where text should be drawn.</param>
        /// <returns>The font size.</returns>
        private float CalculateFontSize(string text, FontFamily fontFamily, float maxWidth, Graphics g)
        {
            // the standard font size
            float fontSize = 20;

            SizeF size;

            // get the max text height
            double maxTextHeightInPoints = 0.5 * (DistanceBetweenImages - 10) / 100.0 * 72.0;

            using (Font standardFont = new Font(fontFamily, fontSize))
            {
                // the size of the text
                size = g.MeasureString(text, standardFont);
            }

            // calculate the font size
            fontSize = (fontSize / size.Width) * maxWidth;
            // if font size is greater than max text height
            if (fontSize > maxTextHeightInPoints)
                return (float)maxTextHeightInPoints;
            // if font size is not greater than max text height
            else
                return fontSize;
        }

        /// <summary>
        /// Sets the new page margins.
        /// </summary>
        /// <param name="pageSettings">The page settings.</param>
        private void SetNewPageMargins(PageSettings pageSettings)
        {
            if (ShowImageHeader || ShowImageFooter || ShowPageHeader || ShowPageFooter)
            {
                Margins currentMargins = pageSettings.Margins;
                Margins newMargins = new Margins(
                    currentMargins.Left,
                    currentMargins.Right,
                    currentMargins.Top,
                    currentMargins.Bottom);

                if (ShowPageHeader)
                    newMargins.Top += HeaderFooterHeight;

                if (ShowImageHeader)
                    newMargins.Top += HeaderFooterHeight;

                if (ShowImageFooter)
                    newMargins.Bottom += HeaderFooterHeight;

                if (ShowPageFooter)
                    newMargins.Bottom += HeaderFooterHeight;
             
                pageSettings.Margins = newMargins;
            }
        }

        #endregion

        #endregion

    }
}
