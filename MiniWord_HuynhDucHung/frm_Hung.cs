using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MiniWord_HuynhDucHung
{
    public partial class frm_Hung : Form
    {
        
        String filePath;
        bool isSaved = true;
        int lengthText = 0;
        int currentLine = 0;
        int currentColumn = 0;
        int curretnPosition = 0;
        int countDoc;
        string defaulFileName = "document";
        FindForm _findForm;

        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int GetCaretPos(ref Point lpPoint);
        public frm_Hung(int count = 1)
        {
            this.countDoc = count;
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadFont();
            Text = defaulFileName + countDoc;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            rtbContent.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lengthText = rtbContent.TextLength;
            statusLength.Text = "Length: " + lengthText;

            getCurrentLine();
            getCurrentColumn(rtbContent, rtbContent.SelectionStart);
            curretnPosition = rtbContent.SelectionStart;
            statusPosition.Text = "Pos: " + curretnPosition;
            isSaved = false;
        }
        private void rtbContent_SelectionChanged(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont == null) return;
            bool isBold = rtbContent.SelectionFont.Bold;
            bool isUnderline = rtbContent.SelectionFont.Underline;
            bool isItalic = rtbContent.SelectionFont.Italic;
            btnBold.CheckState = (isBold ? CheckState.Checked : CheckState.Unchecked);
            btnUnderline.CheckState = (isUnderline ? CheckState.Checked : CheckState.Unchecked);
            btnItalicized.CheckState = (isItalic ? CheckState.Checked : CheckState.Unchecked);

            getCurrentLine();
            getCurrentColumn(rtbContent, rtbContent.SelectionStart);
            curretnPosition = rtbContent.SelectionStart;
            statusPosition.Text = "Pos: " + curretnPosition;

        }
        private void getCurrentLine()
        {
            currentLine = rtbContent.GetLineFromCharIndex(rtbContent.SelectionStart) + 1;
            statusLine.Text = "Ln: " + currentLine;
        }
        private static int GetCorrection(RichTextBox e, int index)
        {
            Point pt1 = Point.Empty;
            GetCaretPos(ref pt1);
            Point pt2 = e.GetPositionFromCharIndex(index);

            if (pt1 != pt2)
                return 1;
            else
                return 0;
        }
        private void getCurrentColumn(RichTextBox e, int index1)
        {

            int correction = GetCorrection(e, index1);
            Point p = e.GetPositionFromCharIndex(index1 - correction);

            if (p.X == 1)
                currentColumn =  1;

            p.X = 0;
            int index2 = e.GetCharIndexFromPosition(p);

            currentColumn = index1 - index2 + 1;
            statusColumn.Text = "Col: " + currentColumn;
        }
        private void loadFont()
        {
            
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            FontFamily[] fontFamilies = installedFonts.Families;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                string fontName = fontFamily.Name;
                cbbFonts.Items.Add(fontName);
            }
        }
        private void cbbFonts_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                exit();
            }
        }
        private void toolExit_Click(object sender, EventArgs e)
        {
            exit();

        }
        private void exit()
        {
            bool exit = true;
            if (!isSaved)
            {

                DialogResult result = ShowCustomMessageBoxExit();
                switch (result)
                {
                    case DialogResult.Yes:
                        save();
                        break;
                    case DialogResult.Cancel:
                        exit = false;
                        break;
                }

            }
            if (exit)
            {
                Application.ExitThread();
            }
        }
        private DialogResult ShowCustomMessageBoxExit()
        {
            DialogResult result = DialogResult.None;
            using (var form = new Form())
            {
                form.Size = new System.Drawing.Size(300, 150);
                form.Text = "Notification";
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var label = new Label
                {
                    Text = "Save to change your this file?",
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, 20)
                };

                var buttonSave = new Button
                {
                    Text = "Save",
                    DialogResult = DialogResult.Yes,
                    Location = new System.Drawing.Point(20, 80)
                };

                var buttonDontSave = new Button
                {
                    Text = "Don't Save",
                    DialogResult = DialogResult.No,
                    Location = new System.Drawing.Point(100, 80)
                };

                var buttonCancel = new Button
                {
                    Text = "Cancel",
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(180, 80)
                };

                buttonSave.Click += (sender, e) =>
                {
                    result = DialogResult.Yes;
                    form.Close();
                };

                buttonDontSave.Click += (sender, e) =>
                {
                    result = DialogResult.No;
                    form.Close();
                };

                buttonCancel.Click += (sender, e) =>
                {
                    result = DialogResult.Cancel;
                    form.Close();
                };

                form.Controls.Add(label);
                form.Controls.Add(buttonSave);
                form.Controls.Add(buttonDontSave);
                form.Controls.Add(buttonCancel);

                form.ShowDialog();

                return result;

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }
        private void toolSave_Click(object sender, EventArgs e)
        {
            save();
        }
        private void toolSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files|.rtb|All Files|.*"; // Change filter to *.rtb
            if(string.IsNullOrEmpty(filePath)) 
                saveFileDialog.FileName = defaulFileName + countDoc + ".rtb";
            else
                saveFileDialog.FileName = Path.GetFileName(filePath);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                saveContentToFile(filePath);
            }
        }
        private void save()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                saveContentToFile(filePath);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files|.rtb|All Files|.*"; // Change filter to *.rtb
                saveFileDialog.FileName = defaulFileName + countDoc + ".rtb";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    saveContentToFile(filePath);
                }
            }
        }
        private void saveContentToFile(string filePath)
        {
            rtbContent.SaveFile(filePath, RichTextBoxStreamType.RichText); // Use RichText instead of PlainText
            isSaved = true;
        }
        private void toolOpenFile_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Files|*.rtb|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbContent.Clear();
                filePath = openFileDialog.FileName;
                rtbContent.LoadFile(filePath, RichTextBoxStreamType.RichText); // Use RichTextStreamType.RichText
                isSaved = true;
                this.Text = Path.GetFileName(filePath);

                lengthText = rtbContent.TextLength;
                statusLength.Text = "Length: " + lengthText;

                getCurrentLine();
                getCurrentColumn(rtbContent, rtbContent.SelectionStart);
            }
        }
        private void cbbFontSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFontSize = int.Parse(cbbFontSizes.SelectedItem.ToString());
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily, selectedFontSize, rtbContent.SelectionFont.Style);
            
        }
        private void cbbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            float initialFontSize = rtbContent.SelectionFont.Size;
            string selectedFont = cbbFonts.SelectedItem.ToString();
            rtbContent.SelectionFont = new Font(selectedFont, initialFontSize, rtbContent.SelectionFont.Style); ;

        }
        private void btnBold_Click(object sender, EventArgs e)
        {
            
            if (rtbContent.SelectionFont != null)
            {
                bool isBold = rtbContent.SelectionFont.Bold;
                if (isBold)
                {
                    btnBold.CheckState = CheckState.Unchecked;
                    rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                            rtbContent.SelectionFont.Size, 
                                                            rtbContent.SelectionFont.Style &
                                                            ~FontStyle.Bold);
                    return;
                }
                btnBold.CheckState = CheckState.Checked;
                // Tạo một kiểu chữ kết hợp
                FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                    rtbContent.SelectionFont.Size,
                                                    currentFontStyle | FontStyle.Bold);
            }
            
            
        }
        private void btnItalicized_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                bool isItalic = rtbContent.SelectionFont.Italic;
                if (isItalic)
                {
                    btnItalicized.CheckState = CheckState.Unchecked;
                    rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                        rtbContent.SelectionFont.Size,
                                                        rtbContent.SelectionFont.Style
                                                        & ~FontStyle.Italic);
                    return;
                }
                btnItalicized.CheckState = CheckState.Checked;

                FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                    rtbContent.SelectionFont.Size,
                                                    currentFontStyle | FontStyle.Italic);
            }
            
        }
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbContent.SelectionFont != null)
            {
                bool isUnderline = rtbContent.SelectionFont.Underline;
                if (isUnderline)
                {
                    btnUnderline.CheckState = CheckState.Unchecked;
                    rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                            rtbContent.SelectionFont.Size,
                                                            rtbContent.SelectionFont.Style 
                                                            & ~FontStyle.Underline);
                    return;
                }
                btnUnderline.CheckState = CheckState.Checked;
                // Tạo một kiểu chữ kết hợp
                FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily,
                                                    rtbContent.SelectionFont.Size,
                                                    currentFontStyle | FontStyle.Underline);
            }
        }
        private void toolNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void NewFile()
        {
            //string appPath = Application.ExecutablePath;
            //System.Diagnostics.Process.Start(appPath);
           
            Thread thread = new Thread(() =>
            {
                Application.Run(new frm_Hung(countDoc + 1));
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            insertPicture();
        }
        private void insertPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                Image image = Image.FromFile(imagePath);

                // Chèn hình ảnh vào vị trí con trỏ trong RichTextBox
                Clipboard.SetImage(image);
                rtbContent.Paste();
            }
        }
        private void toolMenuUndo_Click(object sender, EventArgs e)
        {
              rtbContent.Undo();
            
        }
        private void toolMenuRedo_Click(object sender, EventArgs e)
        {
            rtbContent.Redo();
        }
        private void toolMenuCut_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }
        private void dropBtnTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                rtbContent.SelectionColor = selectedColor;
            }
        }
        private void dropBtnHighLightText_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                
                rtbContent.SelectionBackColor = selectedColor;
            }
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (rtbContent.ZoomFactor < 64.5)
            {
                rtbContent.ZoomFactor = rtbContent.ZoomFactor + (float)0.2;
            }
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (rtbContent.ZoomFactor > 0.515625)
            {
                rtbContent.ZoomFactor = rtbContent.ZoomFactor - (float)0.1;
            }
            
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            

            _findForm = new FindForm(rtbContent,false);
            _findForm.Show(rtbContent);


        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            
            _findForm = new FindForm(rtbContent,true);
            _findForm.Show(rtbContent);

        }
        private void toolInsertPicture_Click(object sender, EventArgs e)
        {
            insertPicture();
        }
        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            if (rtbContent.ZoomFactor < 64.5)
            {
                rtbContent.ZoomFactor = rtbContent.ZoomFactor + (float)0.2;
            }
        }
        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            if (rtbContent.ZoomFactor > 0.515625)
            {
                rtbContent.ZoomFactor = rtbContent.ZoomFactor - (float)0.1;
            }

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbContent.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbContent.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.Redo();
        }
    }
}
