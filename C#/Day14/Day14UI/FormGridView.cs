using BLL.Entities;
using BLL.EntitylLists;
using BLL.EntityManagers;

namespace Day14UI
{
    public partial class FormGridView : Form
    {

        private TitleList titles;
        private BindingSource bindingSource;
        public FormGridView()
        {
            InitializeComponent();
        }

        private void FormGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
        }

        private void DataGridView1_UserDeletingRow(object? sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (bindingSource.Current is Title currentTitle)
            {
                currentTitle.entityState = EntityState.Deleted;

            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                titles = TitleManager.SelectAllTitles();
                bindingSource = new();
                bindingSource.DataSource = titles;
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load data failed : {ex}");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool foundChange = false;

                bindingSource.EndEdit();
                dataGridView1.EndEdit();
                
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
    }
}
