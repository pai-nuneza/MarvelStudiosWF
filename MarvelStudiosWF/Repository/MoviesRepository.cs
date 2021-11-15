using MarvelStudiosWF.Models;
using System.Collections.Generic;

namespace MarvelStudiosWF.Repository
{
    public class MoviesRepository
    {
        Queries que = new Queries();
        public List<Movie> GetMovies() {
            return que.GetAllMovies();
        }

        public bool CreateMovie(Movie movie) {
            return que.CreateMovie(movie);
        }
        public bool UpdateMovie(Movie movie) {
            return que.UpdateMovie(movie);
        }
        public bool DeleteMovie(int Id) {
            return que.DeleteMovie(Id);
        }
    }
}
