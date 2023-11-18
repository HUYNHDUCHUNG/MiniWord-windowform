
namespace MiniWord_HuynhDucHung
{
    partial class frm_Hung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Hung));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalicized = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dropBtnTextColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.dropBtnHighLightText = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cbbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cbbFontSizes = new System.Windows.Forms.ToolStripComboBox();
            this.btnInsertImage = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolMenuStripEdit,
            this.layoutToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewFile,
            this.toolOpenFile,
            this.toolSave,
            this.toolSaveAs,
            this.closeToolStripMenuItem,
            this.toolExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolNewFile
            // 
            this.toolNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolNewFile.Image")));
            this.toolNewFile.Name = "toolNewFile";
            this.toolNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolNewFile.Size = new System.Drawing.Size(186, 22);
            this.toolNewFile.Text = "New File";
            this.toolNewFile.Click += new System.EventHandler(this.toolNewFile_Click);
            // 
            // toolOpenFile
            // 
            this.toolOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolOpenFile.Image")));
            this.toolOpenFile.Name = "toolOpenFile";
            this.toolOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolOpenFile.Size = new System.Drawing.Size(186, 22);
            this.toolOpenFile.Text = "Open File";
            this.toolOpenFile.Click += new System.EventHandler(this.toolOpenFile_Click);
            // 
            // toolSave
            // 
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.Name = "toolSave";
            this.toolSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolSave.Size = new System.Drawing.Size(186, 22);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolSaveAs
            // 
            this.toolSaveAs.Name = "toolSaveAs";
            this.toolSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolSaveAs.Size = new System.Drawing.Size(186, 22);
            this.toolSaveAs.Text = "Save As";
            this.toolSaveAs.Click += new System.EventHandler(this.toolSaveAs_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.Name = "toolExit";
            this.toolExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolExit.Size = new System.Drawing.Size(186, 22);
            this.toolExit.Text = "Exit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // toolMenuStripEdit
            // 
            this.toolMenuStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuUndo,
            this.toolMenuRedo,
            this.toolMenuCut,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.toolMenuStripEdit.Name = "toolMenuStripEdit";
            this.toolMenuStripEdit.Size = new System.Drawing.Size(39, 20);
            this.toolMenuStripEdit.Text = "Edit";
            // 
            // toolMenuUndo
            // 
            this.toolMenuUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuUndo.Image")));
            this.toolMenuUndo.Name = "toolMenuUndo";
            this.toolMenuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolMenuUndo.Size = new System.Drawing.Size(144, 22);
            this.toolMenuUndo.Text = "Undo";
            this.toolMenuUndo.Click += new System.EventHandler(this.toolMenuUndo_Click);
            // 
            // toolMenuRedo
            // 
            this.toolMenuRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuRedo.Image")));
            this.toolMenuRedo.Name = "toolMenuRedo";
            this.toolMenuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolMenuRedo.Size = new System.Drawing.Size(144, 22);
            this.toolMenuRedo.Text = "Redo";
            this.toolMenuRedo.Click += new System.EventHandler(this.toolMenuRedo_Click);
            // 
            // toolMenuCut
            // 
            this.toolMenuCut.Name = "toolMenuCut";
            this.toolMenuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolMenuCut.Size = new System.Drawing.Size(144, 22);
            this.toolMenuCut.Text = "Cut";
            this.toolMenuCut.Click += new System.EventHandler(this.toolMenuCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbContent);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(856, 348);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(856, 397);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPosition,
            this.statusColumn,
            this.statusLine,
            this.statusLength});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(856, 24);
            this.statusStrip1.TabIndex = 0;
            // 
            // statusPosition
            // 
            this.statusPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusPosition.Name = "statusPosition";
            this.statusPosition.Size = new System.Drawing.Size(38, 19);
            this.statusPosition.Text = "Pos: 1";
            // 
            // statusColumn
            // 
            this.statusColumn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Size = new System.Drawing.Size(37, 19);
            this.statusColumn.Text = "Col: 0";
            // 
            // statusLine
            // 
            this.statusLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLine.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(36, 19);
            this.statusLine.Text = "Ln: 0";
            // 
            // statusLength
            // 
            this.statusLength.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLength.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLength.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.statusLength.Name = "statusLength";
            this.statusLength.Size = new System.Drawing.Size(60, 19);
            this.statusLength.Text = "Length: 0";
            // 
            // rtbContent
            // 
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Location = new System.Drawing.Point(0, 0);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(856, 348);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            this.rtbContent.SelectionChanged += new System.EventHandler(this.rtbContent_SelectionChanged);
            this.rtbContent.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnOpenFile,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnBold,
            this.btnItalicized,
            this.btnUnderline,
            this.toolStripSeparator2,
            this.dropBtnTextColor,
            this.dropBtnHighLightText,
            this.toolStripSeparator3,
            this.cbbFonts,
            this.cbbFontSizes,
            this.btnInsertImage,
            this.btnZoomIn,
            this.btnZoomOut,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnNewFile
            // 
            this.btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFile.Image")));
            this.btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(23, 22);
            this.btnNewFile.Text = "New File";
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalicized
            // 
            this.btnItalicized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalicized.Image = ((System.Drawing.Image)(resources.GetObject("btnItalicized.Image")));
            this.btnItalicized.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalicized.Name = "btnItalicized";
            this.btnItalicized.Size = new System.Drawing.Size(23, 22);
            this.btnItalicized.Text = "Italicized";
            this.btnItalicized.Click += new System.EventHandler(this.btnItalicized_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dropBtnTextColor
            // 
            this.dropBtnTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropBtnTextColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropBtnTextColor.Image = ((System.Drawing.Image)(resources.GetObject("dropBtnTextColor.Image")));
            this.dropBtnTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropBtnTextColor.Name = "dropBtnTextColor";
            this.dropBtnTextColor.Size = new System.Drawing.Size(29, 22);
            this.dropBtnTextColor.Text = "Text color";
            this.dropBtnTextColor.Click += new System.EventHandler(this.dropBtnTextColor_Click);
            // 
            // dropBtnHighLightText
            // 
            this.dropBtnHighLightText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropBtnHighLightText.Image = ((System.Drawing.Image)(resources.GetObject("dropBtnHighLightText.Image")));
            this.dropBtnHighLightText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropBtnHighLightText.Name = "dropBtnHighLightText";
            this.dropBtnHighLightText.Size = new System.Drawing.Size(29, 22);
            this.dropBtnHighLightText.Text = "HighLight";
            this.dropBtnHighLightText.Click += new System.EventHandler(this.dropBtnHighLightText_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cbbFonts
            // 
            this.cbbFonts.Name = "cbbFonts";
            this.cbbFonts.Size = new System.Drawing.Size(175, 25);
            this.cbbFonts.Text = "Times New Roman";
            this.cbbFonts.SelectedIndexChanged += new System.EventHandler(this.cbbFonts_SelectedIndexChanged);
            this.cbbFonts.Click += new System.EventHandler(this.cbbFonts_Click);
            // 
            // cbbFontSizes
            // 
            this.cbbFontSizes.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbFontSizes.Name = "cbbFontSizes";
            this.cbbFontSizes.Size = new System.Drawing.Size(75, 25);
            this.cbbFontSizes.Text = "14";
            this.cbbFontSizes.SelectedIndexChanged += new System.EventHandler(this.cbbFontSizes_SelectedIndexChanged);
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInsertImage.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertImage.Image")));
            this.btnInsertImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(23, 22);
            this.btnInsertImage.Text = "Insert Picture";
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "Zoom in";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replaceToolStripMenuItem.Image")));
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // frm_Hung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 421);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Hung";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolNewFile;
        private System.Windows.Forms.ToolStripMenuItem toolOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolSave;
        private System.Windows.Forms.ToolStripMenuItem toolSaveAs;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem toolMenuStripEdit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalicized;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripComboBox cbbFonts;
        private System.Windows.Forms.ToolStripComboBox cbbFontSizes;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton dropBtnTextColor;
        private System.Windows.Forms.ToolStripDropDownButton dropBtnHighLightText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnInsertImage;
        private System.Windows.Forms.ToolStripMenuItem toolMenuUndo;
        private System.Windows.Forms.ToolStripMenuItem toolMenuRedo;
        private System.Windows.Forms.ToolStripMenuItem toolMenuCut;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLength;
        private System.Windows.Forms.ToolStripStatusLabel statusLine;
        private System.Windows.Forms.ToolStripStatusLabel statusColumn;
        private System.Windows.Forms.ToolStripStatusLabel statusPosition;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
    }
}

