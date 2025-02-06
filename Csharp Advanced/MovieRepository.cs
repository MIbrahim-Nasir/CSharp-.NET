namespace Milestone_3
{
    public static class MovieRepository
    {
        private static readonly List<Movie> _movies = new();
        public static List<Movie> GetMovies()
        {
            return _movies;
        }

        public static void AddMovie(Movie movie) {
            if (movie != null)
            {
                _movies.Add(movie);
            }
            else
            {
                throw new MovieEntryException("Movie Details entered are invalid");
            }
        }

    }
}
