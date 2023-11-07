
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
            this.main = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalicized = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.cbbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cbbFontSizes = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main.Location = new System.Drawing.Point(48, 76);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(763, 344);
            this.main.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
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
            this.toolNewFile.Name = "toolNewFile";
            this.toolNewFile.Size = new System.Drawing.Size(180, 22);
            this.toolNewFile.Text = "New File";
            this.toolNewFile.Click += new System.EventHandler(this.toolNewFile_Click);
            // 
            // toolOpenFile
            // 
            this.toolOpenFile.Name = "toolOpenFile";
            this.toolOpenFile.Size = new System.Drawing.Size(180, 22);
            this.toolOpenFile.Text = "Open File";
            this.toolOpenFile.Click += new System.EventHandler(this.toolOpenFile_Click);
            // 
            // toolSave
            // 
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(180, 22);
            this.toolSave.Text = "Save";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolSaveAs
            // 
            this.toolSaveAs.Name = "toolSaveAs";
            this.toolSaveAs.Size = new System.Drawing.Size(180, 22);
            this.toolSaveAs.Text = "Save As";
            this.toolSaveAs.Click += new System.EventHandler(this.toolSaveAs_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(180, 22);
            this.toolExit.Text = "Exit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.homeToolStripMenuItem.Text = "Edit";
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
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbContent);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(856, 372);
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
            // rtbContent
            // 
            this.rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContent.Location = new System.Drawing.Point(3, 30);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(853, 342);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnOpenFile,
            this.btnSave,
            this.btnBold,
            this.btnItalicized,
            this.btnUnderline,
            this.cbbFonts,
            this.cbbFontSizes});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 25);
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
            // frm_Hung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 421);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.main);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Hung";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolNewFile;
        private System.Windows.Forms.ToolStripMenuItem toolOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolSave;
        private System.Windows.Forms.ToolStripMenuItem toolSaveAs;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
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
    }
}

