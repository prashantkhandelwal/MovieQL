using MovieQL.Models;
using MovieQL.Repositories;

namespace MovieQL.Query
{
    public class MoviesQuery
    {
        private readonly IMoviesRepository _moviesRepository;

        public MoviesQuery(IMoviesRepository repo)
        {
            _moviesRepository = repo;
        }

        // As UseProjection attribute is used here.
        // If you want to see how query is executed
        // in the database, then use the below commands
        // to log the queries in MongoDB:
        // db.setLogLevel(1)
        // db.setProfilingLevel(2)
        // db.system.profile.find().pretty()

        [UseProjection]
        public async Task<IExecutable<Movie>> GetMovie(string imdbid)
        {
            var movie = await _moviesRepository.GetMovieById(imdbid).ConfigureAwait(false);
            return movie;
        }
    }
}
