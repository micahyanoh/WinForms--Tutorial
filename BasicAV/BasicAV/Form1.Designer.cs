namespace BasicAV
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
            lbl_file = new Label();
            lbl_md5 = new Label();
            txt_file = new TextBox();
            btn_scan = new Button();
            fileToolStripMenuItem = new ToolStripMenuItem();
            browseToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            lbl_status = new Label();
            txt_md5 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_file
            // 
            lbl_file.AutoSize = true;
            lbl_file.Location = new Point(74, 70);
            lbl_file.Name = "lbl_file";
            lbl_file.Size = new Size(25, 15);
            lbl_file.TabIndex = 2;
            lbl_file.Text = "File";
            // 
            // lbl_md5
            // 
            lbl_md5.AutoSize = true;
            lbl_md5.Location = new Point(74, 103);
            lbl_md5.Name = "lbl_md5";
            lbl_md5.Size = new Size(32, 15);
            lbl_md5.TabIndex = 3;
            lbl_md5.Text = "MD5";
            // 
            // txt_file
            // 
            txt_file.Location = new Point(123, 62);
            txt_file.Name = "txt_file";
            txt_file.Size = new Size(257, 23);
            txt_file.TabIndex = 5;
            // 
            // btn_scan
            // 
            btn_scan.Location = new Point(305, 129);
            btn_scan.Name = "btn_scan";
            btn_scan.Size = new Size(75, 23);
            btn_scan.TabIndex = 6;
            btn_scan.Text = "Scan";
            btn_scan.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem
            // 
            browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            browseToolStripMenuItem.Size = new Size(112, 22);
            browseToolStripMenuItem.Text = "Browse";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(492, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(123, 137);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(67, 15);
            lbl_status.TabIndex = 7;
            lbl_status.Text = "Status: N/A";
            // 
            // txt_md5
            // 
            txt_md5.Location = new Point(123, 95);
            txt_md5.Name = "txt_md5";
            txt_md5.Size = new Size(257, 23);
            txt_md5.TabIndex = 8;
            txt_md5.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 222);
            Controls.Add(txt_md5);
            Controls.Add(lbl_status);
            Controls.Add(btn_scan);
            Controls.Add(txt_file);
            Controls.Add(lbl_md5);
            Controls.Add(lbl_file);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Basic AV";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbl_file;
        private Label lbl_md5;
        private TextBox textBox1;
        private TextBox txt_file;
        private Button btn_scan;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem browseToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label lbl_status;
        private TextBox txt_md5;
    }
}
