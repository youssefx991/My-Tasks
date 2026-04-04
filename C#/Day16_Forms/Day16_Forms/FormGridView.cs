using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Day16_Forms.Context;

namespace Day16_Forms
{
    public partial class FormGridView : Form
    {
        PubsContext Context;

        public FormGridView()
        {
            InitializeComponent();
        }

        private void FormGridView_Load(object sender, EventArgs e)
        {
            Context = new PubsContext();

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context.Titles.Load();

            dataGridView1.DataSource = Context.Titles.Local.ToBindingList();

            dataGridView1.Columns["Pub"].Visible = false;
            dataGridView1.Columns["PubId"].Visible = false;

            Context.Publishers.Load();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataSource = Context.Publishers.Local.ToBindingList();
            comboBoxColumn.DisplayMember = "PubName";
            comboBoxColumn.ValueMember = "PubId";
            comboBoxColumn.DataPropertyName = "PubId";
            comboBoxColumn.HeaderText = "Publisher";
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            Context.SaveChanges();
        }
        private void FormGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Context?.Dispose();
        }
    }
}
