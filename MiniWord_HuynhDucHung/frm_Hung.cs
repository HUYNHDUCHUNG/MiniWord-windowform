using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_HuynhDucHung
{
    public partial class frm_Hung : Form
    {

        String filePath;
        bool isSaved = true;
        public frm_Hung()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            loadFont();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            rtbContent.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
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
            }
        }
        private void cbbFontSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFontSize = int.Parse(cbbFontSizes.SelectedItem.ToString());

            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily, selectedFontSize, rtbContent.SelectionFont.Style);
            
            // Đặt lại vị trí và độ dài của phần văn bản đã chọn ban đầu
            rtbContent.SelectionStart = start;
            rtbContent.SelectionLength = length;
        }
        private void cbbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            float initialFontSize = rtbContent.Font.Size;
            string selectedFont = cbbFonts.SelectedItem.ToString();
            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            rtbContent.SelectionFont = new Font(selectedFont, initialFontSize, rtbContent.Font.Style); ;

            // Đặt lại vị trí và độ dài của phần văn bản đã chọn ban đầu
            rtbContent.SelectionStart = start;
            rtbContent.SelectionLength = length;
            //rtbContent.Font = font;
        }
        private void btnBold_Click(object sender, EventArgs e)
        {
            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            bool isBold = rtbContent.SelectionFont.Bold;
            if (isBold)
            {
                rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily, rtbContent.SelectionFont.Size, rtbContent.SelectionFont.Style & ~FontStyle.Bold);
                return;
            }
            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily,rtbContent.SelectionFont.Size, currentFontStyle | FontStyle.Bold);
            
            // Đặt lại vị trí và độ dài của phần văn bản đã chọn ban đầu
            rtbContent.SelectionStart = start;
            rtbContent.SelectionLength = length;
        }
        private void btnItalicized_Click(object sender, EventArgs e)
        {
            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            bool isItalic = rtbContent.SelectionFont.Italic;
            if (isItalic)
            {
                rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily, rtbContent.SelectionFont.Size, rtbContent.SelectionFont.Style & ~FontStyle.Italic);
                return;
            }


            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily, rtbContent.SelectionFont.Size, currentFontStyle | FontStyle.Italic);


           

            // Đặt lại vị trí và độ dài của phần văn bản đã chọn ban đầu
            rtbContent.SelectionStart = start;
            rtbContent.SelectionLength = length;


            
        }
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            bool isUnderline = rtbContent.SelectionFont.Underline;
            if (isUnderline)
            {
                rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily, rtbContent.SelectionFont.Size, rtbContent.SelectionFont.Style & ~FontStyle.Underline);
                return;
            }

            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font.FontFamily, rtbContent.SelectionFont.Size, currentFontStyle | FontStyle.Underline);

            // Đặt lại vị trí và độ dài của phần văn bản đã chọn ban đầu
            rtbContent.SelectionStart = start;
            rtbContent.SelectionLength = length;

            
            
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
            string appPath = Application.ExecutablePath;

            System.Diagnostics.Process.Start(appPath);
        }

        
    }
}
