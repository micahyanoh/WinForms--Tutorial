using System.Security.Cryptography;
using System.Collections.Generic;
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
        }
    }
}
