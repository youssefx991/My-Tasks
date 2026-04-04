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
        SqlCommand cmd2;

        SqlDataAdapter adapter;
        SqlDataAdapter adapter2;

        DataTable table;
        DataTable table2;

        BindingSource bindingSource;
        BindingNavigator bindingNavigator;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);
            cmd = new SqlCommand("select * from titles", conn);
            cmd2 = new SqlCommand("select * from publishers", conn);

            table = new();
            table2 = new();

            adapter = new SqlDataAdapter(cmd);
            adapter2 = new SqlDataAdapter(cmd2);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            adapter2.InsertCommand = builder.GetInsertCommand();
            adapter2.UpdateCommand = builder.GetUpdateCommand();
            adapter2.DeleteCommand = builder.GetDeleteCommand();


            adapter.Fill(table);
            adapter2.Fill(table2);

            // Set default values for new rows
            if (table.Columns.Contains("title_id"))
                table.Columns["title_id"].DefaultValue = "1";
            if (table.Columns.Contains("type"))
                table.Columns["type"].DefaultValue = "business";
            if (table.Columns.Contains("price"))
                table.Columns["price"].DefaultValue = 0;
            if (table.Columns.Contains("advance"))
                table.Columns["advance"].DefaultValue = 0;
            if (table.Columns.Contains("royalty"))
                table.Columns["royalty"].DefaultValue = 0;
            if (table.Columns.Contains("ytd_sales"))
                table.Columns["ytd_sales"].DefaultValue = 0;
            if (table.Columns.Contains("pubdate"))
                table.Columns["pubdate"].DefaultValue = DateTime.Now;
            if (table2.Rows.Count > 0 && table.Columns.Contains("pub_id"))
                table.Columns["pub_id"].DefaultValue = table2.Rows[0]["pub_id"];
            

            bindingSource = new BindingSource(table, "");
            bindingNavigator = new BindingNavigator(bindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(bindingNavigator);
            listBox1.DataSource = bindingSource;
            listBox1.DisplayMember = "title";
            listBox1.ValueMember = "title_id";

            cb_PID.DataSource = table2;
            cb_PID.DisplayMember = "pub_id";    
            cb_PID.ValueMember = "pub_id";
            cb_PID.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

            cb_TID.DataBindings.Add("Text", bindingSource, "title_id");


            tb_TNotes.DataBindings.Add("Text", bindingSource, "notes");
            tb_tPrice.DataBindings.Add("Value", bindingSource, "price", true);
            tb_PDate.DataBindings.Add("Value", bindingSource, "pubdate");
            tb_TAdvance.DataBindings.Add("Value", bindingSource, "advance", true);


            cb_PName.DataSource = table2;
            cb_PName.DisplayMember = "pub_name";
            cb_PName.ValueMember = "pub_id";
            cb_PName.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

            cb_PCity.DataSource = table2;
            cb_PCity.DisplayMember = "city";
            cb_PCity.ValueMember = "pub_id";
            cb_PCity.DataBindings.Add("SelectedValue", bindingSource, "pub_id");

            cb_title.DataSource = table;
            cb_title.DisplayMember = "Title";
            cb_title.ValueMember = "Title";
            cb_title.DataBindings.Add("SelectedValue", bindingSource, "title");


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
            bindingSource.EndEdit();
            adapter.Update(table);
        }

        private void tb_TNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
