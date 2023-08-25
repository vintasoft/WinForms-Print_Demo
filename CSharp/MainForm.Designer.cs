namespace PrintDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance1 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance2 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance3 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance4 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance5 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailCaption thumbnailCaption1 = new Vintasoft.Imaging.UI.ThumbnailCaption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentLayoutSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docxLayoutSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xlsxLayoutSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printColorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPageHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPageFooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showImageHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showImageFooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showImageRectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageAutoOrientationCheckBox = new System.Windows.Forms.CheckBox();
            this.printImageWithAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.imagesPerPageGroupBox = new System.Windows.Forms.GroupBox();
            this.imagesPerPageUpdateButton = new System.Windows.Forms.Button();
            this.rowsOnPageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.columnsOnPageLabel = new System.Windows.Forms.Label();
            this.rowsOnPageLabel = new System.Windows.Forms.Label();
            this.columnsOnPageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.visiblePagesGroupBox = new System.Windows.Forms.GroupBox();
            this.visibleColumnCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.visibleRowCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.scaleModeComboBox = new System.Windows.Forms.ComboBox();
            this.centerImageOnPageCheckBox = new System.Windows.Forms.CheckBox();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.scaleModeLabel = new System.Windows.Forms.Label();
            this.pageIndexLabel = new System.Windows.Forms.Label();
            this.pageIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.Annotation.UI.AnnotatedThumbnailViewer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.imagesPerPageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOnPageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsOnPageNumericUpDown)).BeginInit();
            this.visiblePagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibleColumnCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleRowCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageIndexNumericUpDown)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.documentLayoutSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.pageSettingsToolStripMenuItem,
            this.printColorManagementToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addToolStripMenuItem.Text = "&Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // documentLayoutSettingsToolStripMenuItem
            // 
            this.documentLayoutSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docxLayoutSettingsToolStripMenuItem,
            this.xlsxLayoutSettingsToolStripMenuItem});
            this.documentLayoutSettingsToolStripMenuItem.Name = "documentLayoutSettingsToolStripMenuItem";
            this.documentLayoutSettingsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.documentLayoutSettingsToolStripMenuItem.Text = "Layout Settings...";
            // 
            // docxLayoutSettingsToolStripMenuItem
            // 
            this.docxLayoutSettingsToolStripMenuItem.Name = "docxLayoutSettingsToolStripMenuItem";
            this.docxLayoutSettingsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.docxLayoutSettingsToolStripMenuItem.Text = "DOCX...";
            this.docxLayoutSettingsToolStripMenuItem.Click += new System.EventHandler(this.docxLayoutSettingsToolStripMenuItem_Click);
            // 
            // xlsxLayoutSettingsToolStripMenuItem
            // 
            this.xlsxLayoutSettingsToolStripMenuItem.Name = "xlsxLayoutSettingsToolStripMenuItem";
            this.xlsxLayoutSettingsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.xlsxLayoutSettingsToolStripMenuItem.Text = "XLSX...";
            this.xlsxLayoutSettingsToolStripMenuItem.Click += new System.EventHandler(this.xlsxLayoutSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.pageSettingsToolStripMenuItem.Text = "Page Settings...";
            this.pageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pageSettingsToolStripMenuItem_Click);
            // 
            // printColorManagementToolStripMenuItem
            // 
            this.printColorManagementToolStripMenuItem.Name = "printColorManagementToolStripMenuItem";
            this.printColorManagementToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.printColorManagementToolStripMenuItem.Text = "Print Color Management...";
            this.printColorManagementToolStripMenuItem.Click += new System.EventHandler(this.printColorManagementToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.printToolStripMenuItem.Text = "&Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorManagementToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // colorManagementToolStripMenuItem
            // 
            this.colorManagementToolStripMenuItem.Name = "colorManagementToolStripMenuItem";
            this.colorManagementToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.colorManagementToolStripMenuItem.Text = "Color Management...";
            this.colorManagementToolStripMenuItem.Click += new System.EventHandler(this.colorManagementToolStripMenuItem_Click);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPageHeaderToolStripMenuItem,
            this.showPageFooterToolStripMenuItem,
            this.showImageHeaderToolStripMenuItem,
            this.showImageFooterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showImageRectToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // showPageHeaderToolStripMenuItem
            // 
            this.showPageHeaderToolStripMenuItem.Name = "showPageHeaderToolStripMenuItem";
            this.showPageHeaderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPageHeaderToolStripMenuItem.Text = "Show Page Header";
            this.showPageHeaderToolStripMenuItem.Click += new System.EventHandler(this.showPageHeaderToolStripMenuItem_Click);
            // 
            // showPageFooterToolStripMenuItem
            // 
            this.showPageFooterToolStripMenuItem.Name = "showPageFooterToolStripMenuItem";
            this.showPageFooterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPageFooterToolStripMenuItem.Text = "Show Page Footer";
            this.showPageFooterToolStripMenuItem.Click += new System.EventHandler(this.showPageFooterToolStripMenuItem_Click);
            // 
            // showImageHeaderToolStripMenuItem
            // 
            this.showImageHeaderToolStripMenuItem.Name = "showImageHeaderToolStripMenuItem";
            this.showImageHeaderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showImageHeaderToolStripMenuItem.Text = "Show Image Header";
            this.showImageHeaderToolStripMenuItem.Click += new System.EventHandler(this.showImageHeaderToolStripMenuItem_Click);
            // 
            // showImageFooterToolStripMenuItem
            // 
            this.showImageFooterToolStripMenuItem.Name = "showImageFooterToolStripMenuItem";
            this.showImageFooterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showImageFooterToolStripMenuItem.Text = "Show Image Footer";
            this.showImageFooterToolStripMenuItem.Click += new System.EventHandler(this.showImageFooterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // showImageRectToolStripMenuItem
            // 
            this.showImageRectToolStripMenuItem.Name = "showImageRectToolStripMenuItem";
            this.showImageRectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showImageRectToolStripMenuItem.Text = "Show Image Rect";
            this.showImageRectToolStripMenuItem.Click += new System.EventHandler(this.showImageRectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FilterIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageAutoOrientationCheckBox);
            this.panel1.Controls.Add(this.printImageWithAnnotationsCheckBox);
            this.panel1.Controls.Add(this.imagesPerPageGroupBox);
            this.panel1.Controls.Add(this.visiblePagesGroupBox);
            this.panel1.Controls.Add(this.zoomTrackBar);
            this.panel1.Controls.Add(this.scaleModeComboBox);
            this.panel1.Controls.Add(this.centerImageOnPageCheckBox);
            this.panel1.Controls.Add(this.zoomLabel);
            this.panel1.Controls.Add(this.scaleModeLabel);
            this.panel1.Controls.Add(this.pageIndexLabel);
            this.panel1.Controls.Add(this.pageIndexNumericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(706, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 2;
            // 
            // imageAutoOrientationCheckBox
            // 
            this.imageAutoOrientationCheckBox.AutoSize = true;
            this.imageAutoOrientationCheckBox.Location = new System.Drawing.Point(146, 28);
            this.imageAutoOrientationCheckBox.Name = "imageAutoOrientationCheckBox";
            this.imageAutoOrientationCheckBox.Size = new System.Drawing.Size(131, 17);
            this.imageAutoOrientationCheckBox.TabIndex = 13;
            this.imageAutoOrientationCheckBox.Text = "Image auto orientation";
            this.imageAutoOrientationCheckBox.UseVisualStyleBackColor = true;
            this.imageAutoOrientationCheckBox.CheckedChanged += new System.EventHandler(this.imageAutoOrientationCheckBox_CheckedChanged);
            // 
            // printImageWithAnnotationsCheckBox
            // 
            this.printImageWithAnnotationsCheckBox.AutoSize = true;
            this.printImageWithAnnotationsCheckBox.Checked = true;
            this.printImageWithAnnotationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printImageWithAnnotationsCheckBox.Location = new System.Drawing.Point(300, 5);
            this.printImageWithAnnotationsCheckBox.Name = "printImageWithAnnotationsCheckBox";
            this.printImageWithAnnotationsCheckBox.Size = new System.Drawing.Size(127, 17);
            this.printImageWithAnnotationsCheckBox.TabIndex = 12;
            this.printImageWithAnnotationsCheckBox.Text = "Print with annotations";
            this.printImageWithAnnotationsCheckBox.UseVisualStyleBackColor = true;
            this.printImageWithAnnotationsCheckBox.CheckedChanged += new System.EventHandler(this.printImageWithAnnotationsCheckBox_CheckedChanged);
            // 
            // imagesPerPageGroupBox
            // 
            this.imagesPerPageGroupBox.Controls.Add(this.imagesPerPageUpdateButton);
            this.imagesPerPageGroupBox.Controls.Add(this.rowsOnPageNumericUpDown);
            this.imagesPerPageGroupBox.Controls.Add(this.columnsOnPageLabel);
            this.imagesPerPageGroupBox.Controls.Add(this.rowsOnPageLabel);
            this.imagesPerPageGroupBox.Controls.Add(this.columnsOnPageNumericUpDown);
            this.imagesPerPageGroupBox.Location = new System.Drawing.Point(246, 49);
            this.imagesPerPageGroupBox.Name = "imagesPerPageGroupBox";
            this.imagesPerPageGroupBox.Size = new System.Drawing.Size(378, 46);
            this.imagesPerPageGroupBox.TabIndex = 11;
            this.imagesPerPageGroupBox.TabStop = false;
            this.imagesPerPageGroupBox.Text = "Images per page";
            // 
            // imagesPerPageUpdateButton
            // 
            this.imagesPerPageUpdateButton.Location = new System.Drawing.Point(316, 17);
            this.imagesPerPageUpdateButton.Name = "imagesPerPageUpdateButton";
            this.imagesPerPageUpdateButton.Size = new System.Drawing.Size(53, 23);
            this.imagesPerPageUpdateButton.TabIndex = 9;
            this.imagesPerPageUpdateButton.Text = "Update";
            this.imagesPerPageUpdateButton.UseVisualStyleBackColor = true;
            this.imagesPerPageUpdateButton.Click += new System.EventHandler(this.imagesPerPageUpdateButton_Click);
            // 
            // rowsOnPageNumericUpDown
            // 
            this.rowsOnPageNumericUpDown.Location = new System.Drawing.Point(260, 19);
            this.rowsOnPageNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsOnPageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsOnPageNumericUpDown.Name = "rowsOnPageNumericUpDown";
            this.rowsOnPageNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.rowsOnPageNumericUpDown.TabIndex = 3;
            this.rowsOnPageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsOnPageNumericUpDown.ValueChanged += new System.EventHandler(this.rowsOnPageNumericUpDown_ValueChanged);
            // 
            // columnsOnPageLabel
            // 
            this.columnsOnPageLabel.AutoSize = true;
            this.columnsOnPageLabel.Location = new System.Drawing.Point(10, 21);
            this.columnsOnPageLabel.Name = "columnsOnPageLabel";
            this.columnsOnPageLabel.Size = new System.Drawing.Size(89, 13);
            this.columnsOnPageLabel.TabIndex = 4;
            this.columnsOnPageLabel.Text = "Columns on page";
            // 
            // rowsOnPageLabel
            // 
            this.rowsOnPageLabel.AutoSize = true;
            this.rowsOnPageLabel.Location = new System.Drawing.Point(173, 21);
            this.rowsOnPageLabel.Name = "rowsOnPageLabel";
            this.rowsOnPageLabel.Size = new System.Drawing.Size(76, 13);
            this.rowsOnPageLabel.TabIndex = 4;
            this.rowsOnPageLabel.Text = "Rows on page";
            // 
            // columnsOnPageNumericUpDown
            // 
            this.columnsOnPageNumericUpDown.Location = new System.Drawing.Point(117, 19);
            this.columnsOnPageNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.columnsOnPageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnsOnPageNumericUpDown.Name = "columnsOnPageNumericUpDown";
            this.columnsOnPageNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.columnsOnPageNumericUpDown.TabIndex = 8;
            this.columnsOnPageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnsOnPageNumericUpDown.ValueChanged += new System.EventHandler(this.columnsOnPageNumericUpDown_ValueChanged);
            // 
            // visiblePagesGroupBox
            // 
            this.visiblePagesGroupBox.Controls.Add(this.visibleColumnCountNumericUpDown);
            this.visiblePagesGroupBox.Controls.Add(this.columnsLabel);
            this.visiblePagesGroupBox.Controls.Add(this.visibleRowCountNumericUpDown);
            this.visiblePagesGroupBox.Controls.Add(this.rowsLabel);
            this.visiblePagesGroupBox.Location = new System.Drawing.Point(6, 49);
            this.visiblePagesGroupBox.Name = "visiblePagesGroupBox";
            this.visiblePagesGroupBox.Size = new System.Drawing.Size(234, 46);
            this.visiblePagesGroupBox.TabIndex = 10;
            this.visiblePagesGroupBox.TabStop = false;
            this.visiblePagesGroupBox.Text = "Visible pages ";
            // 
            // visibleColumnCountNumericUpDown
            // 
            this.visibleColumnCountNumericUpDown.Location = new System.Drawing.Point(71, 19);
            this.visibleColumnCountNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.visibleColumnCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.visibleColumnCountNumericUpDown.Name = "visibleColumnCountNumericUpDown";
            this.visibleColumnCountNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.visibleColumnCountNumericUpDown.TabIndex = 3;
            this.visibleColumnCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.visibleColumnCountNumericUpDown.ValueChanged += new System.EventHandler(this.visibleColumnCountNumericUpDown_ValueChanged);
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(10, 21);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(47, 13);
            this.columnsLabel.TabIndex = 4;
            this.columnsLabel.Text = "Columns";
            // 
            // visibleRowCountNumericUpDown
            // 
            this.visibleRowCountNumericUpDown.Location = new System.Drawing.Point(173, 19);
            this.visibleRowCountNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.visibleRowCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.visibleRowCountNumericUpDown.Name = "visibleRowCountNumericUpDown";
            this.visibleRowCountNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.visibleRowCountNumericUpDown.TabIndex = 3;
            this.visibleRowCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.visibleRowCountNumericUpDown.ValueChanged += new System.EventHandler(this.visibleRowCountNumericUpDown_ValueChanged);
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(132, 21);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(34, 13);
            this.rowsLabel.TabIndex = 4;
            this.rowsLabel.Text = "Rows";
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomTrackBar.Location = new System.Drawing.Point(596, 9);
            this.zoomTrackBar.Maximum = 1000;
            this.zoomTrackBar.Minimum = 10;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(198, 45);
            this.zoomTrackBar.TabIndex = 9;
            this.zoomTrackBar.TickFrequency = 50;
            this.zoomTrackBar.Value = 100;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // scaleModeComboBox
            // 
            this.scaleModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaleModeComboBox.FormattingEnabled = true;
            this.scaleModeComboBox.Location = new System.Drawing.Point(11, 24);
            this.scaleModeComboBox.Name = "scaleModeComboBox";
            this.scaleModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.scaleModeComboBox.TabIndex = 7;
            this.scaleModeComboBox.SelectedValueChanged += new System.EventHandler(this.scaleModeComboBox_SelectedValueChanged);
            // 
            // centerImageOnPageCheckBox
            // 
            this.centerImageOnPageCheckBox.AutoSize = true;
            this.centerImageOnPageCheckBox.Location = new System.Drawing.Point(146, 5);
            this.centerImageOnPageCheckBox.Name = "centerImageOnPageCheckBox";
            this.centerImageOnPageCheckBox.Size = new System.Drawing.Size(130, 17);
            this.centerImageOnPageCheckBox.TabIndex = 6;
            this.centerImageOnPageCheckBox.Text = "Center image on page";
            this.centerImageOnPageCheckBox.UseVisualStyleBackColor = true;
            this.centerImageOnPageCheckBox.CheckedChanged += new System.EventHandler(this.centerImageOnPageCheckBox_CheckedChanged);
            // 
            // zoomLabel
            // 
            this.zoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(556, 12);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(34, 13);
            this.zoomLabel.TabIndex = 4;
            this.zoomLabel.Text = "Zoom";
            // 
            // scaleModeLabel
            // 
            this.scaleModeLabel.AutoSize = true;
            this.scaleModeLabel.Location = new System.Drawing.Point(8, 7);
            this.scaleModeLabel.Name = "scaleModeLabel";
            this.scaleModeLabel.Size = new System.Drawing.Size(63, 13);
            this.scaleModeLabel.TabIndex = 4;
            this.scaleModeLabel.Text = "Scale mode";
            // 
            // pageIndexLabel
            // 
            this.pageIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageIndexLabel.AutoSize = true;
            this.pageIndexLabel.Location = new System.Drawing.Point(800, 17);
            this.pageIndexLabel.Name = "pageIndexLabel";
            this.pageIndexLabel.Size = new System.Drawing.Size(32, 13);
            this.pageIndexLabel.TabIndex = 1;
            this.pageIndexLabel.Text = "Page";
            // 
            // pageIndexNumericUpDown
            // 
            this.pageIndexNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageIndexNumericUpDown.Location = new System.Drawing.Point(838, 15);
            this.pageIndexNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pageIndexNumericUpDown.Name = "pageIndexNumericUpDown";
            this.pageIndexNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.pageIndexNumericUpDown.TabIndex = 0;
            this.pageIndexNumericUpDown.ValueChanged += new System.EventHandler(this.pageIndexNumericUpDown_ValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 124);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.thumbnailViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.printPreviewControl1);
            this.splitContainer1.Size = new System.Drawing.Size(900, 440);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 3;
            // 
            // thumbnailViewer1
            // 
            this.thumbnailViewer1.AllowDrop = true;
            this.thumbnailViewer1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.thumbnailViewer1.Clipboard = winFormsSystemClipboard1;
            this.thumbnailViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            thumbnailAppearance1.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance1.BorderColor = System.Drawing.Color.Gray;
            thumbnailAppearance1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            thumbnailAppearance1.BorderWidth = 1;
            this.thumbnailViewer1.FocusedThumbnailAppearance = thumbnailAppearance1;
            thumbnailAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance2.BorderWidth = 2;
            this.thumbnailViewer1.HoveredThumbnailAppearance = thumbnailAppearance2;
            this.thumbnailViewer1.ImageRotationAngle = 0;
            this.thumbnailViewer1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailViewer1.Name = "thumbnailViewer1";
            thumbnailAppearance3.BackColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance3.BorderWidth = 0;
            this.thumbnailViewer1.NotReadyThumbnailAppearance = thumbnailAppearance3;
            thumbnailAppearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(222)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance4.BorderWidth = 1;
            this.thumbnailViewer1.SelectedThumbnailAppearance = thumbnailAppearance4;
            this.thumbnailViewer1.Size = new System.Drawing.Size(277, 440);
            this.thumbnailViewer1.TabIndex = 0;
            this.thumbnailViewer1.Text = "thumbnailViewer1";
            thumbnailAppearance5.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance5.BorderWidth = 1;
            this.thumbnailViewer1.ThumbnailAppearance = thumbnailAppearance5;
            thumbnailCaption1.Padding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            thumbnailCaption1.TextColor = System.Drawing.Color.Black;
            this.thumbnailViewer1.ThumbnailCaption = thumbnailCaption1;
            this.thumbnailViewer1.ThumbnailContextMenuStrip = this.contextMenuStrip1;
            this.thumbnailViewer1.ThumbnailControlPadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailFlowStyle = Vintasoft.Imaging.UI.ThumbnailFlowStyle.WrappedRows;
            this.thumbnailViewer1.ThumbnailImagePadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailMargin = new System.Windows.Forms.Padding(3);
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            this.thumbnailViewer1.FocusedIndexChanged += new System.EventHandler<Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs>(this.thumbnailViewer1_FocusedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printImageMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 26);
            // 
            // printImageMenuItem
            // 
            this.printImageMenuItem.Name = "printImageMenuItem";
            this.printImageMenuItem.Size = new System.Drawing.Size(135, 22);
            this.printImageMenuItem.Text = "Print image";
            this.printImageMenuItem.Click += new System.EventHandler(this.printImageMenuItem_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(619, 440);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 1D;
            this.printPreviewControl1.StartPageChanged += new System.EventHandler(this.printPreviewControl1_StartPageChanged);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.EnableMetric = true;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.ShowNetwork = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 564);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(793, 460);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Print Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.imagesPerPageGroupBox.ResumeLayout(false);
            this.imagesPerPageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowsOnPageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsOnPageNumericUpDown)).EndInit();
            this.visiblePagesGroupBox.ResumeLayout(false);
            this.visiblePagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibleColumnCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleRowCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageIndexNumericUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown pageIndexNumericUpDown;
		private System.Windows.Forms.Label pageIndexLabel;
		private System.Windows.Forms.Label rowsLabel;
		private System.Windows.Forms.Label columnsLabel;
		private System.Windows.Forms.NumericUpDown visibleRowCountNumericUpDown;
		private System.Windows.Forms.NumericUpDown visibleColumnCountNumericUpDown;
		private System.Windows.Forms.Label zoomLabel;
		private System.Windows.Forms.CheckBox centerImageOnPageCheckBox;
		private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.ComboBox scaleModeComboBox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private System.Windows.Forms.NumericUpDown columnsOnPageNumericUpDown;
		private System.Windows.Forms.Label scaleModeLabel;
		private System.Windows.Forms.Label rowsOnPageLabel;
		private System.Windows.Forms.Label columnsOnPageLabel;
		private System.Windows.Forms.NumericUpDown rowsOnPageNumericUpDown;
		private System.Windows.Forms.TrackBar zoomTrackBar;
		private System.Windows.Forms.GroupBox visiblePagesGroupBox;
		private System.Windows.Forms.GroupBox imagesPerPageGroupBox;
		private System.Windows.Forms.Button imagesPerPageUpdateButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox printImageWithAnnotationsCheckBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem printImageMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private Vintasoft.Imaging.Annotation.UI.AnnotatedThumbnailViewer thumbnailViewer1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPageHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPageFooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showImageHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showImageFooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printColorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showImageRectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentLayoutSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docxLayoutSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xlsxLayoutSettingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox imageAutoOrientationCheckBox;
    }
}