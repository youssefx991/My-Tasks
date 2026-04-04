using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Day13_update
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);
            cmd = new SqlCommand("select * from new_pub_titles_table", conn);

            table = new();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

        }

        private void openConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            this.Text = "connection opened";
        }

        private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Text = "connection closed";

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                return;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                return;

            try
            {
                adapter.Update(table);
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
    }
}
