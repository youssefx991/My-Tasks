using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Day13_Clean
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);
                cmd = new SqlCommand("select * from titles", conn);
                adapter = new SqlDataAdapter(cmd);
                table = new();


                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (table.GetChanges() != null)
            {
                var choice = MessageBox.Show("You still have unsaved changes, discard them anyway?", "warning", MessageBoxButtons.YesNo);
                if (choice == DialogResult.No)
                    return;

            }

            try
            {
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Load failed: {ex.Message}");

            }

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (table.GetChanges() == null)
            {
                MessageBox.Show("Nothing changed to save");
                return;
            }

            try
            {
                adapter.Update(table);
                MessageBox.Show("Changes saved successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Save failed: {ex.Message}");

            }
        }
    }
}
