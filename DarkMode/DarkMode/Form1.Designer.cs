namespace DarkMode
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
            txtName = new TextBox();
            lbl_Name = new Label();
            btn_SayHello = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 35);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 0;
            label1.Text = "HELLO WORLD APP";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(234, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(133, 162);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Name";
            //lbl_Name.Click += this.lbl_Name_Click;
            // 
            // btn_SayHello
            // 
            btn_SayHello.Location = new Point(357, 221);
            btn_SayHello.Name = "btn_SayHello";
            btn_SayHello.Size = new Size(75, 23);
            btn_SayHello.TabIndex = 3;
            btn_SayHello.Text = "Say Hello";
            btn_SayHello.UseVisualStyleBackColor = true;
            btn_SayHello.Click += btn_SayHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_SayHello);
            Controls.Add(lbl_Name);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label lbl_Name;
        private Button btn_SayHello;
    }
}
