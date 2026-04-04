namespace Day14UI
{
    partial class FormDetailedView
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
            listBox1 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            tb_TTitle = new TextBox();
            tb_TType = new TextBox();
            nud_tPrice = new NumericUpDown();
            btn_save = new Button();
            btn_next = new Button();
            btn_previous = new Button();
            tb_PID = new TextBox();
            tb_TID = new TextBox();
            btn_delete = new Button();
            label2 = new Label();
            dtp_PDate = new DateTimePicker();
            label4 = new Label();
            cb_PName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nud_tPrice).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(557, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 429);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 117);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Publisher ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 194);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 115);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 6;
            label6.Text = "Title ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(282, 260);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 9;
            label9.Text = "Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 331);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 10;
            label10.Text = "Price";
            // 
            // tb_TTitle
            // 
            tb_TTitle.Location = new Point(337, 196);
            tb_TTitle.Name = "tb_TTitle";
            tb_TTitle.Size = new Size(150, 31);
            tb_TTitle.TabIndex = 16;
            // 
            // tb_TType
            // 
            tb_TType.Location = new Point(337, 262);
            tb_TType.Name = "tb_TType";
            tb_TType.Size = new Size(150, 31);
            tb_TType.TabIndex = 17;
            // 
            // nud_tPrice
            // 
            nud_tPrice.Location = new Point(337, 329);
            nud_tPrice.Name = "nud_tPrice";
            nud_tPrice.Size = new Size(180, 31);
            nud_tPrice.TabIndex = 18;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(428, 500);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 19;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(160, 500);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(112, 34);
            btn_next.TabIndex = 20;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_previous
            // 
            btn_previous.Location = new Point(22, 500);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(112, 34);
            btn_previous.TabIndex = 21;
            btn_previous.Text = "Previous";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // tb_PID
            // 
            tb_PID.Location = new Point(122, 114);
            tb_PID.Name = "tb_PID";
            tb_PID.Size = new Size(150, 31);
            tb_PID.TabIndex = 22;
            tb_PID.TextChanged += tb_PID_TextChanged;
            // 
            // tb_TID
            // 
            tb_TID.Location = new Point(350, 117);
            tb_TID.Name = "tb_TID";
            tb_TID.Size = new Size(150, 31);
            tb_TID.TabIndex = 24;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(296, 500);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 386);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 26;
            label2.Text = "Publish Date";
            // 
            // dtp_PDate
            // 
            dtp_PDate.Location = new Point(144, 386);
            dtp_PDate.Name = "dtp_PDate";
            dtp_PDate.Size = new Size(300, 31);
            dtp_PDate.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 438);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 28;
            label4.Text = "Publisher Name";
            // 
            // cb_PName
            // 
            cb_PName.FormattingEnabled = true;
            cb_PName.Location = new Point(176, 435);
            cb_PName.Name = "cb_PName";
            cb_PName.Size = new Size(182, 33);
            cb_PName.TabIndex = 29;
            // 
            // FormDetailedView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 562);
            Controls.Add(cb_PName);
            Controls.Add(label4);
            Controls.Add(dtp_PDate);
            Controls.Add(label2);
            Controls.Add(btn_delete);
            Controls.Add(tb_TID);
            Controls.Add(tb_PID);
            Controls.Add(btn_previous);
            Controls.Add(btn_next);
            Controls.Add(btn_save);
            Controls.Add(nud_tPrice);
            Controls.Add(tb_TType);
            Controls.Add(tb_TTitle);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FormDetailedView";
            Text = "FormDetailedView";
            Load += FormDetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)nud_tPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox tb_TTitle;
        private TextBox tb_TType;
        private NumericUpDown nud_tPrice;
        private Button btn_save;
        private Button btn_next;
        private Button btn_previous;
        private TextBox tb_PID;
        private TextBox tb_TID;
        private Button btn_delete;
        private Label label2;
        private DateTimePicker dtp_PDate;
        private Label label4;
        private ComboBox cb_PName;
    }
}