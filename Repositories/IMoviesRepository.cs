using MovieQL.Models;

namespace MovieQL.Repositories
{
    public interface IMoviesRepository
    {
        Task<IExecutable<Movie>> GetMovieById(string IMDBId);
    }
}
