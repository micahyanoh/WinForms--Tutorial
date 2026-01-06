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
            pic_alb = new PictureBox();
            groupBox1 = new GroupBox();
            txt_artist = new TextBox();
            btn_add = new Button();
            txt_abm_name = new TextBox();
            lbl_desc = new Label();
            lbl_img = new Label();
            lbl_year = new Label();
            lbl_artist = new Label();
            lbl_abl_name = new Label();
            txt_year = new TextBox();
            txt_image = new TextBox();
            txt_desc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grid_albums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_alb).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_load_alb
            // 
            btn_load_alb.Location = new Point(349, 25);
            btn_load_alb.Name = "btn_load_alb";
            btn_load_alb.Size = new Size(102, 23);
            btn_load_alb.TabIndex = 0;
            btn_load_alb.Text = "Load Albums";
            btn_load_alb.UseVisualStyleBackColor = true;
            btn_load_alb.Click += btn_load_alb_Click;
            // 
            // grid_albums
            // 
            grid_albums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_albums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_albums.Location = new Point(349, 69);
            grid_albums.Name = "grid_albums";
            grid_albums.Size = new Size(574, 150);
            grid_albums.TabIndex = 1;
            grid_albums.CellClick += grid_albums_CellClick;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            txt_search.Anchor = AnchorStyles.Top;
            txt_search.Location = new Point(584, 25);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(236, 23);
            txt_search.TabIndex = 3;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // pic_alb
            // 
            pic_alb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pic_alb.Location = new Point(349, 245);
            pic_alb.Name = "pic_alb";
            pic_alb.Size = new Size(198, 150);
            pic_alb.SizeMode = PictureBoxSizeMode.Zoom;
            pic_alb.TabIndex = 4;
            pic_alb.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_desc);
            groupBox1.Controls.Add(txt_image);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(txt_abm_name);
            groupBox1.Controls.Add(lbl_desc);
            groupBox1.Controls.Add(lbl_img);
            groupBox1.Controls.Add(lbl_year);
            groupBox1.Controls.Add(lbl_artist);
            groupBox1.Controls.Add(lbl_abl_name);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 370);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Album";
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(100, 104);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(155, 23);
            txt_artist.TabIndex = 12;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(100, 312);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(142, 23);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_abm_name
            // 
            txt_abm_name.Location = new Point(100, 65);
            txt_abm_name.Name = "txt_abm_name";
            txt_abm_name.Size = new Size(214, 23);
            txt_abm_name.TabIndex = 6;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Location = new Point(6, 244);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(67, 15);
            lbl_desc.TabIndex = 5;
            lbl_desc.Text = "Description";
            // 
            // lbl_img
            // 
            lbl_img.AutoSize = true;
            lbl_img.Location = new Point(6, 201);
            lbl_img.Name = "lbl_img";
            lbl_img.Size = new Size(61, 15);
            lbl_img.TabIndex = 4;
            lbl_img.Text = "ImageURL";
            // 
            // lbl_year
            // 
            lbl_year.AutoSize = true;
            lbl_year.Location = new Point(6, 157);
            lbl_year.Name = "lbl_year";
            lbl_year.Size = new Size(29, 15);
            lbl_year.TabIndex = 3;
            lbl_year.Text = "Year";
            // 
            // lbl_artist
            // 
            lbl_artist.AutoSize = true;
            lbl_artist.Location = new Point(6, 108);
            lbl_artist.Name = "lbl_artist";
            lbl_artist.Size = new Size(35, 15);
            lbl_artist.TabIndex = 2;
            lbl_artist.Text = "Artist";
            // 
            // lbl_abl_name
            // 
            lbl_abl_name.AutoSize = true;
            lbl_abl_name.Location = new Point(6, 68);
            lbl_abl_name.Name = "lbl_abl_name";
            lbl_abl_name.Size = new Size(78, 15);
            lbl_abl_name.TabIndex = 1;
            lbl_abl_name.Text = "Album Name";
            // 
            // txt_year
            // 
            txt_year.Location = new Point(100, 153);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(155, 23);
            txt_year.TabIndex = 13;
            // 
            // txt_image
            // 
            txt_image.Location = new Point(100, 197);
            txt_image.Name = "txt_image";
            txt_image.Size = new Size(155, 23);
            txt_image.TabIndex = 14;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(100, 240);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(155, 23);
            txt_desc.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 450);
            Controls.Add(groupBox1);
            Controls.Add(pic_alb);
            Controls.Add(txt_search);
            Controls.Add(btn_search);
            Controls.Add(grid_albums);
            Controls.Add(btn_load_alb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid_albums).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_alb).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_load_alb;
        private DataGridView grid_albums;
        private Button btn_search;
        private TextBox txt_search;
        private PictureBox pic_alb;
        private GroupBox groupBox1;
        private Label lbl_desc;
        private Label lbl_img;
        private Label lbl_year;
        private Label lbl_artist;
        private Label lbl_abl_name;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_abm_name;
        private Button btn_add;
        private TextBox txt_artist;
        private TextBox txt_desc;
        private TextBox txt_image;
        private TextBox txt_year;
    }
}
