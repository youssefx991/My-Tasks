using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Day16_Forms.Context;
using Microsoft.EntityFrameworkCore;

namespace Day16_Forms
{
    public partial class FormDetailedView : Form
    {
        PubsContext Context = new();
        BindingSource bindingSource = new();
        BindingNavigator bindingNavigator = new();

        public FormDetailedView()
        {
            InitializeComponent();
        }

        private void FormDetailedView_Load(object sender, EventArgs e)
        {

            Context.Titles.Load();

            bindingSource.DataSource = Context.Titles.Local.ToBindingList();

            bindingNavigator = new BindingNavigator(bindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(bindingNavigator);


            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "Title1";
            listBox1.ValueMember = "TitleId";

            tb_TID.DataBindings.Add("Text", bindingSource, "TitleId");
            tb_TTitle.DataBindings.Add("Text", bindingSource, "Title1");
            tb_TType.DataBindings.Add("Text", bindingSource, "Type");
            tb_PID.DataBindings.Add("Text", bindingSource, "PubId");
            nud_TPrice.DataBindings.Add("Value", bindingSource, "Price", true);
            dtp_TDate.DataBindings.Add("Text", bindingSource, "PubDate", true);


            Context.Publishers.Load();
            cb_PName.DataSource = Context.Publishers.Local.ToBindingList();
            cb_PName.DisplayMember = "PubName";
            cb_PName.ValueMember = "PubId";
            cb_PName.DataBindings.Add("SelectedValue", bindingSource, "PubId");

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            Context.SaveChanges();
        }
    }
}
