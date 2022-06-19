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
        private readonly SelectedMovieStore _selectedMovieStore;

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

                _selectedMovieStore.selectedMovie = _selectedMovieListingItemViewModel?.Movie;
            }
        }

        public MovieListingViewModel(SelectedMovieStore selectedMovieStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedMovieStore = selectedMovieStore;
            _movieListingItemViewModels = new ObservableCollection<MovieListingItemViewModel>();

            AddMovie(new Movie("Movie 1", "Genre 1", "2014"), modalNavigationStore);
            AddMovie(new Movie("Movie 2", "Genre 2", "2015"), modalNavigationStore);
            AddMovie(new Movie("Movie 3", "Genre 3", "2016"), modalNavigationStore);
        }

        private void AddMovie(Movie movie, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditMovieCommand(movie, modalNavigationStore);
            _movieListingItemViewModels.Add(new MovieListingItemViewModel(movie, editCommand));
        }
    }
}
