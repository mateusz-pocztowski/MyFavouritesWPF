using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Stores
{
    public class SelectedMovieStore
    {
        private readonly MoviesStore _moviesStore;

        private Movie _selectedMovie;

        public Movie SelectedMovie
        {
            get
            {
                return _selectedMovie;
            }
            set
            {
                _selectedMovie = value;
                SelectedMovieChanged?.Invoke();
            }
        }

        public event Action SelectedMovieChanged;

        public SelectedMovieStore(MoviesStore moviesStore)
        {
            _moviesStore = moviesStore;

            _moviesStore.MovieUpdated += MoviesStore_MovieUpdated;
        }

        private void MoviesStore_MovieUpdated(Movie movie)
        {
            if(movie.Id == SelectedMovie?.Id)
            {
                SelectedMovie = movie;
            }
        }
    }
}
