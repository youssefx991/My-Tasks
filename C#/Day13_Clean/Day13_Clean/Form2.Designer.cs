namespace Day13_Clean
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_TID = new TextBox();
            tb_Title = new TextBox();
            tb_TType = new TextBox();
            dtp_PDate = new DateTimePicker();
            cb_PName = new ComboBox();
            btn_save = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(608, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 379);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 1;
            label1.Text = "Title ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 3;
            label3.Text = "Title Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 308);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 4;
            label4.Text = "Publish Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 122);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 5;
            label5.Text = "Publisher Name";
            // 
            // tb_TID
            // 
            tb_TID.Location = new Point(99, 116);
            tb_TID.Name = "tb_TID";
            tb_TID.Size = new Size(150, 31);
            tb_TID.TabIndex = 9;
            // 
            // tb_Title
            // 
            tb_Title.Location = new Point(99, 173);
            tb_Title.Name = "tb_Title";
            tb_Title.Size = new Size(150, 31);
            tb_Title.TabIndex = 10;
            // 
            // tb_TType
            // 
            tb_TType.Location = new Point(99, 233);
            tb_TType.Name = "tb_TType";
            tb_TType.Size = new Size(150, 31);
            tb_TType.TabIndex = 11;
            // 
            // dtp_PDate
            // 
            dtp_PDate.Location = new Point(166, 303);
            dtp_PDate.Name = "dtp_PDate";
            dtp_PDate.Size = new Size(300, 31);
            dtp_PDate.TabIndex = 15;
            // 
            // cb_PName
            // 
            cb_PName.FormattingEnabled = true;
            cb_PName.Location = new Point(420, 119);
            cb_PName.Name = "cb_PName";
            cb_PName.Size = new Size(182, 33);
            cb_PName.TabIndex = 16;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(462, 404);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 18;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(cb_PName);
            Controls.Add(dtp_PDate);
            Controls.Add(tb_TType);
            Controls.Add(tb_Title);
            Controls.Add(tb_TID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
        private TextBox tb_TID;
        private TextBox tb_Title;
        private TextBox tb_TType;
        private DateTimePicker dtp_PDate;
        private ComboBox cb_PName;
        private Button btn_save;
    }
}