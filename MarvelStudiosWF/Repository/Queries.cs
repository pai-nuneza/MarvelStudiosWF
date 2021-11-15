using MarvelStudiosWF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MarvelStudiosWF.Repository
{
    public class Queries
    {
     
        public List<Movie> GetAllMovies() {

            List<Movie> movies = new List<Movie>();
            string query = "SELECT * FROM Movies";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectionString();
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = (int)reader["Id"];
                    string Title = (string)reader["Title"];
                    string Genre = (string)reader["Genre"];
                    DateTime ReleasedDate = (DateTime)reader["ReleasedDate"];
                    string Director = (string)reader["Director"];
                    decimal Budget = (decimal)reader["Budget"];
                    movies.Add(new Movie() { Id = Id, Title = Title, Genre = Genre, ReleasedDate = ReleasedDate, Director = Director, Budget = Budget });
                }
            }
            
            return movies;
        }
        public bool CreateMovie(Movie movie) {

            string query = "INSERT INTO Movies (Title, Genre, ReleasedDate, Director, Budget)" +
                            "VALUES (@pTitle, @pGenre, @pReleasedDate, @pDirector, @pBudget)";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectionString();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pTitle", movie.Title);
                cmd.Parameters.AddWithValue("@pGenre", movie.Genre);
                cmd.Parameters.AddWithValue("@pReleasedDate", movie.ReleasedDate);
                cmd.Parameters.AddWithValue("@pDirector", movie.Director);
                cmd.Parameters.AddWithValue("@pBudget", movie.Budget);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateMovie(Movie movie) {
            string query = "UPDATE Movies SET Title = @pTitle, Genre = @pGenre, ReleasedDate = @pReleasedDate," +
                "Director = @pDirector, Budget = @pBudget WHERE Id = @pId";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectionString();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pId", movie.Id);
                cmd.Parameters.AddWithValue("@pTitle", movie.Title);
                cmd.Parameters.AddWithValue("@pGenre", movie.Genre);
                cmd.Parameters.AddWithValue("@pReleasedDate", movie.ReleasedDate);
                cmd.Parameters.AddWithValue("@pDirector", movie.Director);
                cmd.Parameters.AddWithValue("@pBudget", movie.Budget);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteMovie(int Id) {
            string query = "DELETE FROM Movies WHERE Id = @pId";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = GetConnectionString();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pId", Id);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        static private string GetConnectionString()
        {
            return "Server=PETERSEBASTIAN\\SQLEXPRESS01;Database=MarvelStudios;Integrated Security=true;";
        }
    }
}
