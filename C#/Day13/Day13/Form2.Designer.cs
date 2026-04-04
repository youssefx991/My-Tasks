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
            lbl_publisher_id = new Label();
            tb_pcountry = new TextBox();
            tb_pname = new TextBox();
            tb_pcity = new TextBox();
            tb_pstate = new TextBox();
            tb_tPrice = new NumericUpDown();
            tb_TAdvance = new NumericUpDown();
            tb_PDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_previous = new Button();
            btn_next = new Button();
            lbl_titleid = new Label();
            label9 = new Label();
            tb_title = new TextBox();
            label10 = new Label();
            tb_tType = new TextBox();
            label11 = new Label();
            tb_TNotes = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label12 = new Label();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)tb_tPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_TAdvance).BeginInit();
            SuspendLayout();
            // 
            // lbl_publisher_id
            // 
            lbl_publisher_id.AutoSize = true;
            lbl_publisher_id.Location = new Point(127, 115);
            lbl_publisher_id.Name = "lbl_publisher_id";
            lbl_publisher_id.Size = new Size(0, 25);
            lbl_publisher_id.TabIndex = 0;
            // 
            // tb_pcountry
            // 
            tb_pcountry.Location = new Point(127, 340);
            tb_pcountry.Name = "tb_pcountry";
            tb_pcountry.Size = new Size(150, 31);
            tb_pcountry.TabIndex = 1;
            // 
            // tb_pname
            // 
            tb_pname.Location = new Point(127, 169);
            tb_pname.Name = "tb_pname";
            tb_pname.Size = new Size(150, 31);
            tb_pname.TabIndex = 2;
            // 
            // tb_pcity
            // 
            tb_pcity.Location = new Point(127, 223);
            tb_pcity.Name = "tb_pcity";
            tb_pcity.Size = new Size(150, 31);
            tb_pcity.TabIndex = 3;
            // 
            // tb_pstate
            // 
            tb_pstate.Location = new Point(127, 286);
            tb_pstate.Name = "tb_pstate";
            tb_pstate.Size = new Size(150, 31);
            tb_pstate.TabIndex = 4;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 286);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 10;
            label4.Text = "P. State";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 340);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 11;
            label5.Text = "P. Country";
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
            // lbl_titleid
            // 
            lbl_titleid.AutoSize = true;
            lbl_titleid.Location = new Point(491, 115);
            lbl_titleid.Name = "lbl_titleid";
            lbl_titleid.Size = new Size(0, 25);
            lbl_titleid.TabIndex = 17;
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
            // tb_title
            // 
            tb_title.Location = new Point(491, 166);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(150, 31);
            tb_title.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 220);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 21;
            label10.Text = "Type";
            // 
            // tb_tType
            // 
            tb_tType.Location = new Point(491, 220);
            tb_tType.Name = "tb_tType";
            tb_tType.Size = new Size(150, 31);
            tb_tType.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 437);
            label11.Name = "label11";
            label11.Size = new Size(59, 25);
            label11.TabIndex = 23;
            label11.Text = "Notes";
            // 
            // tb_TNotes
            // 
            tb_TNotes.Location = new Point(94, 437);
            tb_TNotes.Multiline = true;
            tb_TNotes.Name = "tb_TNotes";
            tb_TNotes.Size = new Size(646, 131);
            tb_TNotes.TabIndex = 22;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 659);
            Controls.Add(btn_save);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label11);
            Controls.Add(tb_TNotes);
            Controls.Add(label10);
            Controls.Add(tb_tType);
            Controls.Add(label9);
            Controls.Add(tb_title);
            Controls.Add(lbl_titleid);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_PDate);
            Controls.Add(tb_TAdvance);
            Controls.Add(tb_tPrice);
            Controls.Add(tb_pstate);
            Controls.Add(tb_pcity);
            Controls.Add(tb_pname);
            Controls.Add(tb_pcountry);
            Controls.Add(lbl_publisher_id);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)tb_tPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_TAdvance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_publisher_id;
        private TextBox tb_pcountry;
        private TextBox tb_pname;
        private TextBox tb_pcity;
        private TextBox tb_pstate;
        private NumericUpDown tb_tPrice;
        private NumericUpDown tb_TAdvance;
        private DateTimePicker tb_PDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_previous;
        private Button btn_next;
        private Label lbl_titleid;
        private Label label9;
        private TextBox tb_title;
        private Label label10;
        private TextBox tb_tType;
        private Label label11;
        private TextBox tb_TNotes;
        private ListBox listBox1;
        private Label label1;
        private Label label12;
        private Button btn_save;
    }
}