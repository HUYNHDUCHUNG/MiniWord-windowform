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
            loadFont();
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

        private void toolExit_Click(object sender, EventArgs e)
        {

            if (!isSaved)
            {
                DialogResult result = ShowCustomMessageBox("Save to change your this file?"
                                                            , "Notification", "Save", "Don't Save", "Cancel");
            }
            else
            {
                Application.Exit();
            }
            

        }
        private DialogResult ShowCustomMessageBox(string message, string caption, string button1Text, string button2Text, string button3Text)
        {
            using (var form = new Form())
            {
                form.Size = new System.Drawing.Size(300, 150);
                form.Text = caption;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var label = new Label
                {
                    Text = message,
                    AutoSize = true,
                    Location = new System.Drawing.Point(20, 20)
                };

                var button1 = new Button
                {
                    Text = button1Text,
                    DialogResult = DialogResult.Yes,
                    Location = new System.Drawing.Point(20, 80)
                };

                var button2 = new Button
                {
                    Text = button2Text,
                    DialogResult = DialogResult.No,
                    Location = new System.Drawing.Point(100, 80)
                };

                var button3 = new Button
                {
                    Text = button3Text,
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(180, 80)
                };

                button1.Click += (sender, e) =>
                {
                    save();
                    Application.Exit();
                }
                ;
                button2.Click += (sender, e) => {
                    Application.Exit();
                };

                form.Controls.Add(label);
                form.Controls.Add(button1);
                form.Controls.Add(button2);
                form.Controls.Add(button3);

                return form.ShowDialog();
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
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
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
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    saveContentToFile(filePath);
                }
            }
        }

        private void saveContentToFile(string filePath)
        {
            rtbContent.SaveFile(filePath, RichTextBoxStreamType.PlainText);
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
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                rtbContent.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }

        private void cbbFontSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFontSize = int.Parse(cbbFontSizes.SelectedItem.ToString());
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont.FontFamily, selectedFontSize);
        }

        private void cbbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = cbbFonts.SelectedItem.ToString();
            Font font = new Font(selectedFont, rtbContent.Font.Size);
            rtbContent.Font = font;
        }





        private void btnBold_Click(object sender, EventArgs e)
        {
            // Lưu vị trí bắt đầu và kết thúc của phần văn bản cần tô đen
            int start = rtbContent.SelectionStart;
            int length = rtbContent.SelectionLength;

            bool isBold = rtbContent.SelectionFont.Bold;
            if (isBold)
            {
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style & ~FontStyle.Bold);
                return;
            }

            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font, currentFontStyle | FontStyle.Bold);



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
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style & ~FontStyle.Italic);
                return;
            }


            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font, currentFontStyle | FontStyle.Italic);


           

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
                rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style & ~FontStyle.Underline);
                return;
            }

            // Tạo một kiểu chữ kết hợp
            FontStyle currentFontStyle = rtbContent.SelectionFont.Style;
            rtbContent.SelectionFont = new Font(rtbContent.Font, currentFontStyle | FontStyle.Underline);

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
