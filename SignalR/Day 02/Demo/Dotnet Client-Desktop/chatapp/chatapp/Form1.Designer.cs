namespace chatapp
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
            txt_mess = new TextBox();
            btn_send = new Button();
            lb_mess = new ListBox();
            SuspendLayout();
            // 
            // txt_mess
            // 
            txt_mess.Location = new Point(108, 72);
            txt_mess.Name = "txt_mess";
            txt_mess.Size = new Size(150, 31);
            txt_mess.TabIndex = 1;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(310, 75);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(112, 34);
            btn_send.TabIndex = 2;
            btn_send.Text = "send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // lb_mess
            // 
            lb_mess.FormattingEnabled = true;
            lb_mess.Location = new Point(104, 170);
            lb_mess.Name = "lb_mess";
            lb_mess.Size = new Size(254, 229);
            lb_mess.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_mess);
            Controls.Add(btn_send);
            Controls.Add(txt_mess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_mess;
        private Button btn_send;
        private ListBox lb_mess;
    }
}
