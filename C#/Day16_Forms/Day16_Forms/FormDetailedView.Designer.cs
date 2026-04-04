namespace Day16_Forms
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_PID = new TextBox();
            tb_TTitle = new TextBox();
            tb_TType = new TextBox();
            nud_TPrice = new NumericUpDown();
            dtp_TDate = new DateTimePicker();
            btn_Previous = new Button();
            btn_Next = new Button();
            btn_Save = new Button();
            cb_PName = new ComboBox();
            tb_TID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_TPrice).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(616, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 329);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 134);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Publisher ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 185);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 3;
            label3.Text = "Title ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 235);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 4;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 287);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 5;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 343);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 6;
            label6.Text = "Publish Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 86);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 7;
            label7.Text = "Publisher Name";
            // 
            // tb_PID
            // 
            tb_PID.Location = new Point(428, 131);
            tb_PID.Name = "tb_PID";
            tb_PID.Size = new Size(150, 31);
            tb_PID.TabIndex = 8;
            // 
            // tb_TTitle
            // 
            tb_TTitle.Location = new Point(134, 185);
            tb_TTitle.Name = "tb_TTitle";
            tb_TTitle.Size = new Size(150, 31);
            tb_TTitle.TabIndex = 11;
            // 
            // tb_TType
            // 
            tb_TType.Location = new Point(134, 235);
            tb_TType.Name = "tb_TType";
            tb_TType.Size = new Size(150, 31);
            tb_TType.TabIndex = 12;
            // 
            // nud_TPrice
            // 
            nud_TPrice.Location = new Point(134, 285);
            nud_TPrice.Name = "nud_TPrice";
            nud_TPrice.Size = new Size(180, 31);
            nud_TPrice.TabIndex = 13;
            // 
            // dtp_TDate
            // 
            dtp_TDate.Location = new Point(134, 338);
            dtp_TDate.Name = "dtp_TDate";
            dtp_TDate.Size = new Size(300, 31);
            dtp_TDate.TabIndex = 14;
            // 
            // btn_Previous
            // 
            btn_Previous.Location = new Point(64, 395);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(112, 34);
            btn_Previous.TabIndex = 15;
            btn_Previous.Text = "Previous";
            btn_Previous.UseVisualStyleBackColor = true;
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(198, 395);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(112, 34);
            btn_Next.TabIndex = 16;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(466, 395);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 34);
            btn_Save.TabIndex = 18;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // cb_PName
            // 
            cb_PName.FormattingEnabled = true;
            cb_PName.Location = new Point(174, 83);
            cb_PName.Name = "cb_PName";
            cb_PName.Size = new Size(182, 33);
            cb_PName.TabIndex = 19;
            // 
            // tb_TID
            // 
            tb_TID.Location = new Point(134, 135);
            tb_TID.Name = "tb_TID";
            tb_TID.Size = new Size(150, 31);
            tb_TID.TabIndex = 20;
            // 
            // FormDetailedView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_TID);
            Controls.Add(cb_PName);
            Controls.Add(btn_Save);
            Controls.Add(btn_Next);
            Controls.Add(btn_Previous);
            Controls.Add(dtp_TDate);
            Controls.Add(nud_TPrice);
            Controls.Add(tb_TType);
            Controls.Add(tb_TTitle);
            Controls.Add(tb_PID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FormDetailedView";
            Text = "FormDetailedView";
            Load += FormDetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)nud_TPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_PID;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tb_TTitle;
        private TextBox tb_TType;
        private NumericUpDown nud_TPrice;
        private DateTimePicker dtp_TDate;
        private Button btn_Previous;
        private Button btn_Next;
        private Button btn_Save;
        private ComboBox cb_PName;
        private TextBox tb_TID;
    }
}