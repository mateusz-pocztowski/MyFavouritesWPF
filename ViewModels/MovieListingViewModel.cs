using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFavouritesWPF.Models;
using System.Windows.Input;
using MyFavouritesWPF.Commands;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieListingViewModel : ViewModelBase
    {
        private readonly MoviesStore _moviesStore;
        private readonly SelectedMovieStore _selectedMovieStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        private readonly ObservableCollection<MovieListingItemViewModel> _movieListingItemViewModels;

        public IEnumerable<MovieListingItemViewModel> MovieListingItemViewModels => _movieListingItemViewModels;

        private MovieListingItemViewModel _selectedMovieListingItemViewModel;

        public MovieListingItemViewModel SelectedMovieListingItemViewModel
        {
            get
            {
                return _selectedMovieListingItemViewModel;
            }
            set
            {
                _selectedMovieListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedMovieListingItemViewModel));

                _selectedMovieStore.SelectedMovie = _selectedMovieListingItemViewModel?.Movie;
            }
        }

        public MovieListingViewModel(MoviesStore moviesStore, SelectedMovieStore selectedMovieStore, ModalNavigationStore modalNavigationStore)
        {
            _moviesStore = moviesStore;
            _selectedMovieStore = selectedMovieStore;
            _modalNavigationStore = modalNavigationStore;
            _movieListingItemViewModels = new ObservableCollection<MovieListingItemViewModel>();

            _moviesStore.MovieAdded += MoviesStore_MovieAdded;
            _moviesStore.MovieUpdated += MoviesStore_MovieUpdated;
        }

        protected override void Dispose()
        {
            _moviesStore.MovieAdded -= MoviesStore_MovieAdded;
            _moviesStore.MovieUpdated -= MoviesStore_MovieUpdated;
            base.Dispose();
        }

        private void MoviesStore_MovieAdded(Movie movie)
        {
            AddMovie(movie);
        }

        private void MoviesStore_MovieUpdated(Movie movie)
        {
            UpdateMovie(movie);
        }

        private void AddMovie(Movie movie)
        {
            MovieListingItemViewModel viewModel = new MovieListingItemViewModel(movie, _moviesStore, _modalNavigationStore);
            _movieListingItemViewModels.Add(viewModel);
        }

        private void UpdateMovie(Movie movie)
        {
            MovieListingItemViewModel movieViewModel = _movieListingItemViewModels.FirstOrDefault(m => m.Movie.Id == movie.Id);

            if(movieViewModel != null)
            {
                movieViewModel.Update(movie);
            } 
        }
    }
}
