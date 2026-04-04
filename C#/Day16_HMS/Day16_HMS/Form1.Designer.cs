namespace Day16_HMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            loadReservationToolStripMenuItem = new ToolStripMenuItem();
            LoadKitchensStripMenuItem = new ToolStripMenuItem();
            loadFrontendToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadReservationToolStripMenuItem, LoadKitchensStripMenuItem, loadFrontendToolStripMenuItem, saveToolStripMenuItem1 });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(92, 29);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // loadReservationToolStripMenuItem
            // 
            loadReservationToolStripMenuItem.Name = "loadReservationToolStripMenuItem";
            loadReservationToolStripMenuItem.Size = new Size(270, 34);
            loadReservationToolStripMenuItem.Text = "Load Reservations";
            loadReservationToolStripMenuItem.Click += loadReservationToolStripMenuItem_Click;
            // 
            // LoadKitchensStripMenuItem
            // 
            LoadKitchensStripMenuItem.Name = "LoadKitchensStripMenuItem";
            LoadKitchensStripMenuItem.Size = new Size(270, 34);
            LoadKitchensStripMenuItem.Text = "Load Kitchens";
            LoadKitchensStripMenuItem.Click += LoadKitchensStripMenuItem_Click;
            // 
            // loadFrontendToolStripMenuItem
            // 
            loadFrontendToolStripMenuItem.Name = "loadFrontendToolStripMenuItem";
            loadFrontendToolStripMenuItem.Size = new Size(270, 34);
            loadFrontendToolStripMenuItem.Text = "Load Frontend";
            loadFrontendToolStripMenuItem.Click += loadFrontendToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(270, 34);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(808, 429);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 462);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem loadReservationToolStripMenuItem;
        private ToolStripMenuItem LoadKitchensStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem loadFrontendToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
    }
}
