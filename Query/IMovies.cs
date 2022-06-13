using MovieQL.Models;

namespace MovieQL.Query
{
    public interface IMovies
    {
        public Task<IExecutable<Movie>> GetMovie(string IMDBId);
    }
}
