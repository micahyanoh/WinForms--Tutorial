using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_load_alb_Click(object sender, EventArgs e)
        {
            //AlbumDAO albumDAO = new AlbumDAO();
            //Album a1 = new Album
            //{
            //    ID = 1,
            //    AlbumName = "Thriller",
            //    ArtistName = "Michael Jackson",
            //    Year = 1982,
            //    ImageUrl = "https://example.com/thriller.jpg",
            //    Description = "The best-selling album of all time."
            //};
            //Album a2 = new Album
            //{
            //    ID = 2,
            //    AlbumName = "Back in Black",
            //    ArtistName = "AC/DC",
            //    Year = 1980,
            //    ImageUrl = "https://example.com/backinblack.jpg",
            //    Description = "A classic rock album."
            //};
            //Album a3 = new Album
            //{
            //    ID = 3,
            //    AlbumName = "The Dark Side of the Moon",
            //    ArtistName = "Pink Floyd",
            //    Year = 1973,
            //    ImageUrl = "https://example.com/darksidemoon.jpg",
            //    Description = "A progressive rock masterpiece."
            //};
            //albumDAO.albums = new List<Album> { a1, a2, a3 };
            //albumBindingSource.DataSource = albumDAO.GetAllAlbums();
            //grid_albums.DataSource = albumBindingSource;
            AlbumDAO albumDAO = new AlbumDAO();
            albumBindingSource.DataSource = albumDAO.GetAllAlbums();
            grid_albums.DataSource = albumBindingSource;
            pic_alb.LoadAsync("https://raw.githubusercontent.com/github/explore/main/topics/csharp/csharp.png");

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();
            albumBindingSource.DataSource = albumDAO.SearchTitle(txt_search.Text);
            grid_albums.DataSource = albumBindingSource;

        }

        private async void grid_albums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid and the cell value is not null
            if (e.RowIndex >= 0 && grid_albums.Rows[e.RowIndex].Cells[4].Value != null)
            {
                string imgURL = grid_albums.Rows[e.RowIndex].Cells[4].Value.ToString();

                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        // Fake a browser request
                        wc.Headers.Add("User-Agent", "Mozilla/5.0");

                        // Use DownloadDataTaskAsync for async/await support
                        byte[] imageBytes = await wc.DownloadDataTaskAsync(imgURL);

                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pic_alb.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Image blocked by server (403 Forbidden).");
                }
            }
        }
        public void clearFields()
        {
            txt_abm_name.Text = "";
            txt_artist.Text = "";
            txt_year.Text = "";
            txt_image.Text = "";
            txt_desc.Text = "";
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album
            {
                AlbumName = txt_abm_name.Text,
                ArtistName = txt_artist.Text,
                Year = int.Parse(txt_year.Text),
                ImageUrl = txt_image.Text,
                Description = txt_desc.Text
            };

            AlbumDAO albumDAO = new AlbumDAO();
           int result = albumDAO.AddNewAlbum(newAlbum);

            MessageBox.Show(result > 0 ? $"{result} Album added successfully!" : "Failed to add album.");
            clearFields();
        }
    }
}
