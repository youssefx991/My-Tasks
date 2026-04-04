using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace Day13_Clean
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand cmdTitles;
        private SqlCommand cmdPublishers;
        private SqlDataAdapter adapterTitles;
        private SqlDataAdapter adapterPublishers;
        private DataTable tableTitles;
        private DataTable tablePublishers;

        BindingSource bindingSource;
        BindingNavigator bindingNavigator;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeData();
            LoadData();
        }

        private void InitializeData()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);
                cmdTitles = new SqlCommand("select * from titles", conn);
                cmdPublishers = new SqlCommand("select * from publishers", conn);
                adapterTitles = new SqlDataAdapter(cmdTitles);
                adapterPublishers = new SqlDataAdapter(cmdPublishers);
                tablePublishers = new();
                tableTitles = new();
                bindingSource = new BindingSource(tableTitles, "");
                bindingNavigator = new BindingNavigator(bindingSource);
                bindingNavigator.Dock = DockStyle.Top;
                this.Controls.Add(bindingNavigator);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapterTitles);
                adapterTitles.InsertCommand = builder.GetInsertCommand();
                adapterTitles.UpdateCommand = builder.GetUpdateCommand();
                adapterTitles.DeleteCommand = builder.GetDeleteCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialize Data Failed : {ex}");
            }
        }

        private void LoadData()
        {

            adapterTitles.Fill(tableTitles);
            bindingSource.DataSource = tableTitles;

            tb_TID.DataBindings.Add("Text", bindingSource, "title_id");
            tb_Title.DataBindings.Add("Text", bindingSource, "title");
            tb_TType.DataBindings.Add("Text", bindingSource, "type");
            dtp_PDate.DataBindings.Add("Text", bindingSource, "pubdate");


            adapterPublishers.Fill(tablePublishers);
            cb_PName.DataSource = tablePublishers;
            cb_PName.DisplayMember = "pub_name";
            cb_PName.ValueMember = "pub_id";
            cb_PName.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "title";
            listBox1.ValueMember = "title_id";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.EndEdit();
                if (tableTitles.GetChanges() == null)
                    MessageBox.Show("Nothing changed to be saved");
                adapterTitles.Update(tableTitles);
                MessageBox.Show("Saved Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save Data Failed : {ex}");
            }

        }

        
    }
}
