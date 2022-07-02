using MyFavouritesWPF.Models;
using MyFavouritesWPF.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Stores
{
    public class MoviesStore
    {
        private readonly IGetAllMoviesQuery _getAllMoviesQuery;
        private readonly IGetAllGenresQuery _getAllGenresQuery;
        private readonly ICreateMovieCommand _createMovieCommand;
        private readonly IUpdateMovieCommand _updateMovieCommand;
        private readonly IDeleteMovieCommand _deleteMovieCommand;

        private readonly List<Movie> _movies;
        private readonly List<Genre> _genres;
        public IEnumerable<Movie> Movies => _movies;
        public IEnumerable<Genre> Genres => _genres;

        public MoviesStore(
            IGetAllMoviesQuery getAllMoviesQuery,
            IGetAllGenresQuery getAllGenresQuery,
            ICreateMovieCommand createMovieCommand,
            IUpdateMovieCommand updateMovieCommand,
            IDeleteMovieCommand deleteMovieCommand)
        {
            _getAllMoviesQuery = getAllMoviesQuery;
            _getAllGenresQuery = getAllGenresQuery;
            _createMovieCommand = createMovieCommand;
            _updateMovieCommand = updateMovieCommand;
            _deleteMovieCommand = deleteMovieCommand;

            _movies = new List<Movie>();
            _genres = new List<Genre>();
        }

        public event Action MoviesLoaded;
        public event Action<Movie> MovieAdded;
        public event Action<Movie> MovieUpdated;
        public event Action<Guid> MovieDeleted;
        public async Task Load()
        {
            IEnumerable<Genre> genres = await _getAllGenresQuery.Execute();
            IEnumerable<Movie> movies = await _getAllMoviesQuery.Execute();

            _movies.Clear();
            _movies.AddRange(movies);
            
            _genres.Clear();
            _genres.AddRange(genres);

            MoviesLoaded?.Invoke();
        }
        public async Task Add(Movie movie)
        {
            await _createMovieCommand.Execute(movie);

            _movies.Add(movie);

            MovieAdded?.Invoke(movie);
        }
        public async Task Update(Movie movie)
        {
            await _updateMovieCommand.Execute(movie);

            int currentIndex = _movies.FindIndex(m => m.Id == movie.Id);

            if(currentIndex != -1)
            {
                _movies[currentIndex] = movie;
            }

            MovieUpdated?.Invoke(movie);
        }
        public async Task Delete(Guid id)
        {
            await _deleteMovieCommand.Execute(id);

            _movies.RemoveAll(m => m.Id == id);

            MovieDeleted?.Invoke(id);
        }
    }
}
