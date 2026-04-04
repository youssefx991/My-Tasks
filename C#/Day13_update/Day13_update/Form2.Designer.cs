namespace Day13
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_tPrice = new NumericUpDown();
            tb_TAdvance = new NumericUpDown();
            tb_PDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_previous = new Button();
            btn_next = new Button();
            label9 = new Label();
            label11 = new Label();
            tb_TNotes = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label12 = new Label();
            btn_save = new Button();
            cb_PName = new ComboBox();
            cb_PCity = new ComboBox();
            cb_title = new ComboBox();
            cb_PID = new ComboBox();
            cb_TID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)tb_tPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_TAdvance).BeginInit();
            SuspendLayout();
            // 
            // tb_tPrice
            // 
            tb_tPrice.Location = new Point(491, 334);
            tb_tPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            tb_tPrice.Name = "tb_tPrice";
            tb_tPrice.Size = new Size(180, 31);
            tb_tPrice.TabIndex = 5;
            // 
            // tb_TAdvance
            // 
            tb_TAdvance.Location = new Point(491, 387);
            tb_TAdvance.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            tb_TAdvance.Name = "tb_TAdvance";
            tb_TAdvance.Size = new Size(180, 31);
            tb_TAdvance.TabIndex = 6;
            // 
            // tb_PDate
            // 
            tb_PDate.Location = new Point(491, 270);
            tb_PDate.Name = "tb_PDate";
            tb_PDate.Size = new Size(300, 31);
            tb_PDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 8;
            label2.Text = "P. Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 9;
            label3.Text = "P. City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 387);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 12;
            label6.Text = "Advance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 275);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 13;
            label7.Text = "Publish Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 336);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 14;
            label8.Text = "Price";
            // 
            // btn_previous
            // 
            btn_previous.Location = new Point(15, 613);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(112, 34);
            btn_previous.TabIndex = 15;
            btn_previous.Text = "Previous";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(679, 613);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(112, 34);
            btn_next.TabIndex = 16;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 166);
            label9.Name = "label9";
            label9.Size = new Size(44, 25);
            label9.TabIndex = 19;
            label9.Text = "Title";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 287);
            label11.Name = "label11";
            label11.Size = new Size(59, 25);
            label11.TabIndex = 23;
            label11.Text = "Notes";
            // 
            // tb_TNotes
            // 
            tb_TNotes.Location = new Point(75, 287);
            tb_TNotes.Multiline = true;
            tb_TNotes.Name = "tb_TNotes";
            tb_TNotes.Size = new Size(276, 279);
            tb_TNotes.TabIndex = 22;
            tb_TNotes.TextChanged += tb_TNotes_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(871, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(431, 479);
            listBox1.TabIndex = 24;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 25;
            label1.Text = "Publisher ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(374, 115);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 26;
            label12.Text = "Title ID";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(1173, 613);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 27;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // cb_PName
            // 
            cb_PName.FormattingEnabled = true;
            cb_PName.Location = new Point(127, 166);
            cb_PName.Name = "cb_PName";
            cb_PName.Size = new Size(182, 33);
            cb_PName.TabIndex = 28;
            // 
            // cb_PCity
            // 
            cb_PCity.FormattingEnabled = true;
            cb_PCity.Location = new Point(127, 223);
            cb_PCity.Name = "cb_PCity";
            cb_PCity.Size = new Size(182, 33);
            cb_PCity.TabIndex = 29;
            // 
            // cb_title
            // 
            cb_title.FormattingEnabled = true;
            cb_title.Location = new Point(489, 163);
            cb_title.Name = "cb_title";
            cb_title.Size = new Size(376, 33);
            cb_title.TabIndex = 32;
            // 
            // cb_PID
            // 
            cb_PID.FormattingEnabled = true;
            cb_PID.Location = new Point(127, 107);
            cb_PID.Name = "cb_PID";
            cb_PID.Size = new Size(182, 33);
            cb_PID.TabIndex = 34;
            // 
            // cb_TID
            // 
            cb_TID.FormattingEnabled = true;
            cb_TID.Location = new Point(489, 107);
            cb_TID.Name = "cb_TID";
            cb_TID.Size = new Size(182, 33);
            cb_TID.TabIndex = 35;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 659);
            Controls.Add(cb_TID);
            Controls.Add(cb_PID);
            Controls.Add(cb_title);
            Controls.Add(cb_PCity);
            Controls.Add(cb_PName);
            Controls.Add(btn_save);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label11);
            Controls.Add(tb_TNotes);
            Controls.Add(label9);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_PDate);
            Controls.Add(tb_TAdvance);
            Controls.Add(tb_tPrice);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)tb_tPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_TAdvance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown tb_tPrice;
        private NumericUpDown tb_TAdvance;
        private DateTimePicker tb_PDate;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_previous;
        private Button btn_next;
        private Label label9;
        private Label label11;
        private TextBox tb_TNotes;
        private ListBox listBox1;
        private Label label1;
        private Label label12;
        private Button btn_save;
        private ComboBox cb_PName;
        private ComboBox cb_PCity;
        private ComboBox cb_title;
        private ComboBox cb_PID;
        private ComboBox cb_TID;
    }
}