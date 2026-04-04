using BLL.EntitylLists;
using BLL.EntityManagers;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day14UI
{
    public partial class FormDetailedView : Form
    {
        public FormDetailedView()
        {
            InitializeComponent();
        }

        PublisherList publishers;
        TitleList titles;
        BindingSource bindingSource = new();
        BindingNavigator bindingNavigator;
  

        private void FormDetailedView_Load(object sender, EventArgs e)
        {
            InitializeData();
            LoadData();
        }

        private void InitializeData()
        {
            try
            {
                publishers = PublisherManager.SelectAllPublishers();
                titles = TitleManager.SelectAllTitles();
                bindingSource.DataSource = titles;
                bindingNavigator = new BindingNavigator(bindingSource);
                bindingNavigator.Dock = DockStyle.Top;
                this.Controls.Add(bindingNavigator);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialize Data Failed : {ex}");
            }


        }

        private void LoadData()
        {

            tb_TID.Clear();
            tb_TTitle.Clear();
            tb_TType.Clear();
            nud_tPrice.Value = 0;
            dtp_PDate.Value = DateTime.Now;
            
            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "title";
            listBox1.ValueMember = "title_id";

            tb_TID.DataBindings.Add("Text", bindingSource, "title_id");
            tb_TTitle.DataBindings.Add("Text", bindingSource, "title");
            tb_TType.DataBindings.Add("Text", bindingSource, "type");
            nud_tPrice.DataBindings.Add("Value", bindingSource, "price", true);
            dtp_PDate.DataBindings.Add("Text", bindingSource, "pubdate", true);

            tb_PID.DataBindings.Add("Text", bindingSource, "pub_id");

            cb_PName.DataSource = publishers;
            cb_PName.DisplayMember = "pub_name";
            cb_PName.ValueMember = "pub_id";
            cb_PName.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

        }
        private void BindingSourcePublishers_AddingNew(object? sender, AddingNewEventArgs e)
        {

        }

        private void BindingSourceTitles_AddingNew(object? sender, AddingNewEventArgs e)
        {

        }

        private void OnAddNewTitle(object sender, EventArgs e)
        {

        }
        private void btn_previous_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }



        private void updatePublishersData()
        {

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool foundChange = false;

                bindingSource.EndEdit();

                foreach (Title t in titles.ToList())
                {
                    if (t.entityState == EntityState.Modified)
                    {
                        if (TitleManager.UpdateTitle(t))
                        {
                            t.entityState = EntityState.UnChanged;
                            foundChange = true;
                        }
                    }
                    else if (t.entityState == EntityState.Added)
                    {
                        if (TitleManager.InsertTitle(t))
                        {
                            t.entityState = EntityState.UnChanged;
                            foundChange = true;
                        }
                    }
                    else if (t.entityState == EntityState.Deleted)
                    {
                        if (TitleManager.DeleteTitle(t))
                        {
                            t.entityState = EntityState.UnChanged;
                            bindingSource.Remove(t);
                            foundChange = true;
                        }
                    }
                }

                if (foundChange)
                {
                    MessageBox.Show("Save data successfully");
                }
                else
                {
                    MessageBox.Show("No change to save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save data failed : {ex}");
            }
        }
        private void tb_PID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Title currentTitle)
            {
                currentTitle.entityState = EntityState.Deleted;
            }
        }
    }
}
