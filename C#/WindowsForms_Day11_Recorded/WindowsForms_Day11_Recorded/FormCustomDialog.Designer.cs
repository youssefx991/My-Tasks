namespace WindowsForms_Day11_Recorded
{
    partial class FormCustomDialog
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
            tb_customDialog = new TextBox();
            btn_apply = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // tb_customDialog
            // 
            tb_customDialog.Location = new Point(110, 49);
            tb_customDialog.Name = "tb_customDialog";
            tb_customDialog.PlaceholderText = "Type Here";
            tb_customDialog.Size = new Size(654, 31);
            tb_customDialog.TabIndex = 0;
            // 
            // btn_apply
            // 
            btn_apply.DialogResult = DialogResult.OK;
            btn_apply.Location = new Point(12, 196);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(112, 34);
            btn_apply.TabIndex = 1;
            btn_apply.Text = "Apply";
            btn_apply.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(758, 196);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 34);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // FormCustomDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 242);
            Controls.Add(btn_cancel);
            Controls.Add(btn_apply);
            Controls.Add(tb_customDialog);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormCustomDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCustomDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_customDialog;
        private Button btn_apply;
        private Button btn_cancel;
    }
}