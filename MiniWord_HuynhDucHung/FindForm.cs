using System;
using System.Windows.Forms;

namespace MiniWord_HuynhDucHung
{
    public partial class FindForm : Form
    {
		private RichTextBox _richTextBox;
		private bool isReplace;
		public FindForm(RichTextBox richTextBox,bool isReplace)
		{
			InitializeComponent();
			this.isReplace = isReplace;
			_richTextBox = richTextBox;
		}

	

		private void FindForm_Load(object sender, EventArgs e)
		{
            this.Text = isReplace ? "Find" : "Replace";
            pnlReplace.Visible = isReplace;
        }

		void BtnFindNextClick(object sender, EventArgs e)
		{
			int index;
			RichTextBoxFinds options = RichTextBoxFinds.None;
            if (chkMatchCase.Checked)
                options |= RichTextBoxFinds.MatchCase;
            if (chkMatchWholeWord.Checked)
                options |= RichTextBoxFinds.WholeWord;


            index = _richTextBox.Find(txtFindText.Text, _richTextBox.SelectionStart + _richTextBox.SelectionLength, options);
			if (index == -1)
			{
				MessageBox.Show($"Cannot find \"{txtFindText.Text}\"", "Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				_richTextBox.SelectionStart = index;
				_richTextBox.SelectionLength = txtFindText.Text.Length;
			}
			
			_richTextBox.Focus();
		}
		
		void BtnReplaceClick(object sender, EventArgs e)
		{
			if (_richTextBox.SelectedText != "")
				_richTextBox.SelectedText = txtReplace.Text;
		}

		void BtnReplaceAllClick(object sender, EventArgs e)
		{

			//rtbFind.Text = rtbFind.Text.Replace(tbFind.Text, tbReplace.Text);
			string searchText = txtFindText.Text;
			string replaceText = txtReplace.Text;
			int startIndex = 0;
			int index = _richTextBox.Find(searchText, startIndex, RichTextBoxFinds.None);

			while (index != -1)
			{
				_richTextBox.SelectedText = replaceText;

				startIndex = index + replaceText.Length;
				index = _richTextBox.Find(searchText, startIndex, RichTextBoxFinds.None);
			}	
		}

        
    }
}
