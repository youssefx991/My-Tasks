namespace Lab2Desktop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            tb_publicmessage = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            btn_createroom = new Button();
            btn_deleteroom = new Button();
            btn_addusertroom = new Button();
            btn_sendpublicmessage = new Button();
            btn_sendprivatemessage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Create Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 95);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Delete Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 160);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "Add User To Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 253);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "Select Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 299);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 4;
            label5.Text = "Send Public Message";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 384);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 5;
            label6.Text = "Select User";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 442);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 6;
            label7.Text = "Send Private Message";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(114, 544);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // tb_publicmessage
            // 
            tb_publicmessage.Location = new Point(276, 300);
            tb_publicmessage.Name = "tb_publicmessage";
            tb_publicmessage.Size = new Size(150, 31);
            tb_publicmessage.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 442);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(274, 160);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(279, 253);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(282, 393);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 14;
            // 
            // btn_createroom
            // 
            btn_createroom.Location = new Point(539, 37);
            btn_createroom.Name = "btn_createroom";
            btn_createroom.Size = new Size(166, 34);
            btn_createroom.TabIndex = 15;
            btn_createroom.Text = "create room";
            btn_createroom.UseVisualStyleBackColor = true;
            // 
            // btn_deleteroom
            // 
            btn_deleteroom.Location = new Point(543, 103);
            btn_deleteroom.Name = "btn_deleteroom";
            btn_deleteroom.Size = new Size(172, 34);
            btn_deleteroom.TabIndex = 16;
            btn_deleteroom.Text = "delete room";
            btn_deleteroom.UseVisualStyleBackColor = true;
            // 
            // btn_addusertroom
            // 
            btn_addusertroom.Location = new Point(550, 158);
            btn_addusertroom.Name = "btn_addusertroom";
            btn_addusertroom.Size = new Size(181, 34);
            btn_addusertroom.TabIndex = 17;
            btn_addusertroom.Text = "add user to room";
            btn_addusertroom.UseVisualStyleBackColor = true;
            // 
            // btn_sendpublicmessage
            // 
            btn_sendpublicmessage.Location = new Point(483, 299);
            btn_sendpublicmessage.Name = "btn_sendpublicmessage";
            btn_sendpublicmessage.Size = new Size(199, 34);
            btn_sendpublicmessage.TabIndex = 19;
            btn_sendpublicmessage.Text = "send public message";
            btn_sendpublicmessage.UseVisualStyleBackColor = true;
            btn_sendpublicmessage.Click += btn_sendpublicmessage_Click;
            // 
            // btn_sendprivatemessage
            // 
            btn_sendprivatemessage.Location = new Point(483, 447);
            btn_sendprivatemessage.Name = "btn_sendprivatemessage";
            btn_sendprivatemessage.Size = new Size(193, 34);
            btn_sendprivatemessage.TabIndex = 21;
            btn_sendprivatemessage.Text = "send private message";
            btn_sendprivatemessage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 742);
            Controls.Add(btn_sendprivatemessage);
            Controls.Add(btn_sendpublicmessage);
            Controls.Add(btn_addusertroom);
            Controls.Add(btn_deleteroom);
            Controls.Add(btn_createroom);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(tb_publicmessage);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox tb_publicmessage;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button btn_createroom;
        private Button btn_deleteroom;
        private Button btn_addusertroom;
        private Button btn_sendpublicmessage;
        private Button btn_sendprivatemessage;
    }
}
