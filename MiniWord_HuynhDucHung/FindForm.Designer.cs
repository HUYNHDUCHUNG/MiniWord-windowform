
namespace MiniWord_HuynhDucHung
{
    partial class FindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.chkMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radDirectionUp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fi&nd what:";
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Location = new System.Drawing.Point(7, 7);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(98, 18);
            this.chkMatchCase.TabIndex = 1;
            this.chkMatchCase.Text = "Match &case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(310, 14);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(80, 24);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindNextClick);
            // 
            // txtFindText
            // 
            this.txtFindText.Location = new System.Drawing.Point(85, 15);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(222, 20);
            this.txtFindText.TabIndex = 0;
            // 
            // chkMatchWholeWord
            // 
            this.chkMatchWholeWord.Location = new System.Drawing.Point(7, 30);
            this.chkMatchWholeWord.Name = "chkMatchWholeWord";
            this.chkMatchWholeWord.Size = new System.Drawing.Size(137, 18);
            this.chkMatchWholeWord.TabIndex = 1;
            this.chkMatchWholeWord.Text = "Match &whole word";
            this.chkMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radDirectionUp);
            this.groupBox1.Location = new System.Drawing.Point(147, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "&Down";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radDirectionUp
            // 
            this.radDirectionUp.Location = new System.Drawing.Point(14, 21);
            this.radDirectionUp.Name = "radDirectionUp";
            this.radDirectionUp.Size = new System.Drawing.Size(52, 20);
            this.radDirectionUp.TabIndex = 0;
            this.radDirectionUp.Text = "&Up";
            this.radDirectionUp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Re&place with:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(85, 4);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(221, 20);
            this.txtReplace.TabIndex = 0;
            // 
            // pnlReplace
            // 
            this.pnlReplace.Controls.Add(this.btnReplaceAll);
            this.pnlReplace.Controls.Add(this.btnReplace);
            this.pnlReplace.Controls.Add(this.label2);
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReplace.Location = new System.Drawing.Point(0, 46);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(402, 65);
            this.pnlReplace.TabIndex = 6;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(310, 37);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(80, 24);
            this.btnReplaceAll.TabIndex = 1;
            this.btnReplaceAll.Text = "Replace &All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.BtnReplaceAllClick);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(310, 6);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(80, 24);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplaceClick);
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.label1);
            this.pnlFind.Controls.Add(this.txtFindText);
            this.pnlFind.Controls.Add(this.btnFindNext);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFind.Location = new System.Drawing.Point(0, 0);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(402, 46);
            this.pnlFind.TabIndex = 7;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.chkMatchCase);
            this.pnlOptions.Controls.Add(this.chkMatchWholeWord);
            this.pnlOptions.Controls.Add(this.groupBox1);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 111);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(402, 63);
            this.pnlOptions.TabIndex = 8;
            // 
            // FindForm
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 172);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlReplace);
            this.Controls.Add(this.pnlFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindForm";
            this.groupBox1.ResumeLayout(false);
            this.pnlReplace.ResumeLayout(false);
            this.pnlReplace.PerformLayout();
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion






        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radDirectionUp;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkMatchWholeWord;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Label label1;


    }
}