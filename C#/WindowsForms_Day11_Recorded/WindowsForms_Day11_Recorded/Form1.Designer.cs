namespace WindowsForms_Day11_Recorded
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
            btn_open = new Button();
            btn_close = new Button();
            btn_save = new Button();
            btn_font = new Button();
            btn_color = new Button();
            btn_custom = new Button();
            richTextBox = new RichTextBox();
            dlg_color = new ColorDialog();
            dlg_font = new FontDialog();
            dlg_open = new OpenFileDialog();
            dlg_save = new SaveFileDialog();
            SuspendLayout();
            // 
            // btn_open
            // 
            btn_open.Location = new Point(28, 12);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(112, 34);
            btn_open.TabIndex = 0;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.Location = new Point(676, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(112, 34);
            btn_close.TabIndex = 1;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Top;
            btn_save.Location = new Point(331, 12);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_font
            // 
            btn_font.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_font.Location = new Point(28, 404);
            btn_font.Name = "btn_font";
            btn_font.Size = new Size(112, 34);
            btn_font.TabIndex = 3;
            btn_font.Text = "Font";
            btn_font.UseVisualStyleBackColor = true;
            btn_font.Click += btn_font_Click;
            // 
            // btn_color
            // 
            btn_color.Anchor = AnchorStyles.Bottom;
            btn_color.Location = new Point(331, 404);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(112, 34);
            btn_color.TabIndex = 4;
            btn_color.Text = "Color";
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // btn_custom
            // 
            btn_custom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_custom.Location = new Point(676, 404);
            btn_custom.Name = "btn_custom";
            btn_custom.Size = new Size(112, 34);
            btn_custom.TabIndex = 5;
            btn_custom.Text = "Custom";
            btn_custom.UseVisualStyleBackColor = true;
            btn_custom.Click += btn_custom_Click;
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new Point(28, 52);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(760, 331);
            richTextBox.TabIndex = 6;
            richTextBox.Text = "";
            // 
            // dlg_open
            // 
            dlg_open.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(btn_custom);
            Controls.Add(btn_color);
            Controls.Add(btn_font);
            Controls.Add(btn_save);
            Controls.Add(btn_close);
            Controls.Add(btn_open);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_open;
        private Button btn_close;
        private Button btn_save;
        private Button btn_font;
        private Button btn_color;
        private Button btn_custom;
        private RichTextBox richTextBox;
        private ColorDialog dlg_color;
        private FontDialog dlg_font;
        private OpenFileDialog dlg_open;
        private SaveFileDialog dlg_save;
    }
}
