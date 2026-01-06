using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;



namespace MusicApp
{
    internal class AlbumDAO
    {

        private static readonly string connectionString = "Server=.;Database=music_db;User Id=nodeuser;Password=M!c@h-2025;TrustServerCertificate=True;Encrypt=True";
        private SqlConnection connection = new SqlConnection(connectionString);
        public  List<Album> albums = new List<Album>();
        
        public List<Album> GetAllAlbums()
        {
            connection.Open();
            string cmd = "select * from tb_album";
            SqlCommand command = new SqlCommand(cmd, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            { 
                while (reader.Read()) {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageUrl = reader.GetString(4),
                        Description = reader.GetString(5)

                    };
                 albums.Add(album);

                }

            }

            connection.Close();
            return albums;

        }

        public List<Album> SearchTitle(string searchTerm)
        {
            connection.Open();
            string cmd = "select * from tb_album where alb_title like @search";
            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageUrl = reader.GetString(4),
                        Description = reader.GetString(5)

                    };
                    albums.Add(album);

                }

            }

            connection.Close();
            return albums;

        }

        internal int AddNewAlbum(Album newAlbum)
        {
            connection.Open();
            string cmd = "insert into tb_album values(@albumtitle,@artist,@year,@imageURL,@description)";
            SqlCommand command = new SqlCommand(cmd, connection);
            command.Parameters.AddWithValue("@albumtitle", newAlbum.AlbumName);
            command.Parameters.AddWithValue("@artist", newAlbum.ArtistName);
            command.Parameters.AddWithValue("@year", newAlbum.Year);
            command.Parameters.AddWithValue("@imageURL", newAlbum.ImageUrl);
            command.Parameters.AddWithValue("@description", newAlbum.Description);
            int rowsAffected=command.ExecuteNonQuery();

            connection.Close();
            return rowsAffected;
        }
    }
}
