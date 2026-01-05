namespace MusicApp
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
            btn_load_alb = new Button();
            grid_albums = new DataGridView();
            btn_search = new Button();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grid_albums).BeginInit();
            SuspendLayout();
            // 
            // btn_load_alb
            // 
            btn_load_alb.Location = new Point(223, 25);
            btn_load_alb.Name = "btn_load_alb";
            btn_load_alb.Size = new Size(102, 23);
            btn_load_alb.TabIndex = 0;
            btn_load_alb.Text = "Load Albums";
            btn_load_alb.UseVisualStyleBackColor = true;
            btn_load_alb.Click += btn_load_alb_Click;
            // 
            // grid_albums
            // 
            grid_albums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_albums.Location = new Point(231, 69);
            grid_albums.Name = "grid_albums";
            grid_albums.Size = new Size(692, 150);
            grid_albums.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(848, 25);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 23);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(584, 25);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(236, 23);
            txt_search.TabIndex = 3;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 450);
            Controls.Add(txt_search);
            Controls.Add(btn_search);
            Controls.Add(grid_albums);
            Controls.Add(btn_load_alb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid_albums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_load_alb;
        private DataGridView grid_albums;
        private Button btn_search;
        private TextBox txt_search;
    }
}
