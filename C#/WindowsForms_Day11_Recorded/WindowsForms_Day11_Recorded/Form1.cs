using System.Runtime.CompilerServices;

namespace WindowsForms_Day11_Recorded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            dlg_open.Filter = "Rich Text Format|*.rtf|Text Files|*.txt";
            dlg_open.InitialDirectory = "C:\\TestWinForms";
            if (dlg_open.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(dlg_open.FileName, (RichTextBoxStreamType)(dlg_open.FilterIndex) - 1);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dlg_save.Filter = "Rich Text Format|*.rtf|Text Files|*.txt";
            dlg_save.InitialDirectory = "C:\\TestWinForms";
            if (dlg_save.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(dlg_save.FileName, (RichTextBoxStreamType)(dlg_save.FilterIndex) - 1);
            }
        }
        private void btn_font_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText?.Length > 0)
                dlg_font.Font = richTextBox.SelectionFont;

            if (dlg_font.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = dlg_font.Font;
            }
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText?.Length > 0)
                dlg_color.Color = richTextBox.SelectionColor;

            if (dlg_color.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = dlg_color.Color;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var choice = MessageBox.Show("Are you sure that you want to close? (Yes/No)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        FormCustomDialog CustomDialog = new();
        private void btn_custom_Click(object sender, EventArgs e)
        {
            if (CustomDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.AppendText(CustomDialog.UserText.ToUpper());
            }
        }
    }
}
