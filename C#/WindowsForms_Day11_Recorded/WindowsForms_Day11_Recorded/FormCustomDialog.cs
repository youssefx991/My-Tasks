using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_Day11_Recorded
{
    public partial class FormCustomDialog : Form
    {
        public FormCustomDialog()
        {
            InitializeComponent();
        }

        public string UserText
        {
            get=>tb_customDialog.Text;
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
