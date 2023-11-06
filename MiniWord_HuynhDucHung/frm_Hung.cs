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
        public frm_Hung()
        {
            InitializeComponent();
            loadFont();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void loadFont()
        {
            
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            // Lấy danh sách các font
            FontFamily[] fontFamilies = installedFonts.Families;

            // Hiển thị danh sách các font
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
            Application.Exit();
        }
    }
}
