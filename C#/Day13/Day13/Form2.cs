using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;
        BindingSource bindingSource;
        BindingNavigator bindingNavigator;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);
            cmd = new SqlCommand("select * from new_pub_titles_table", conn);

            table = new();
            adapter = new SqlDataAdapter(cmd);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            adapter.Fill(table);


            bindingSource = new BindingSource(table, "");
            bindingNavigator = new BindingNavigator(bindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(bindingNavigator);

            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "title";
            listBox1.ValueMember = "title_id";

            lbl_publisher_id.DataBindings.Add("Text", bindingSource, "pub_id");
            tb_pname.DataBindings.Add("Text", bindingSource, "pub_name");
            tb_pcity.DataBindings.Add("Text", bindingSource, "city");
            tb_pstate.DataBindings.Add("Text", bindingSource, "state");
            tb_pcountry.DataBindings.Add("Text", bindingSource, "country");

            lbl_titleid.DataBindings.Add("Text", bindingSource, "title_id");
            tb_title.DataBindings.Add("Text", bindingSource, "title");
            tb_tType.DataBindings.Add("Text", bindingSource, "type");
            tb_TNotes.DataBindings.Add("Text", bindingSource, "notes");
            tb_tPrice.DataBindings.Add("Value", bindingSource, "price", true);
            tb_PDate.DataBindings.Add("Value", bindingSource, "pubdate");
            tb_TAdvance.DataBindings.Add("Value", bindingSource, "advance", true);
            //MessageBox.Show($"Loaded {table.Rows.Count} rows from SQLExpress.");
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = listBox1.SelectedValue.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
        }
    }
}
