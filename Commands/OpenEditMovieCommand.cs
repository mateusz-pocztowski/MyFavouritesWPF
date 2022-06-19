using MyFavouritesWPF.Models;
using MyFavouritesWPF.Stores;
using MyFavouritesWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Commands
{
    public class OpenEditMovieCommand : CommandBase
    {
        private readonly MoviesStore _moviesStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly MovieListingItemViewModel _movieListingItemViewModel;

        public OpenEditMovieCommand(MovieListingItemViewModel movieListingItemViewModel, MoviesStore moviesStore, ModalNavigationStore modalNavigationStore)
        {
            _movieListingItemViewModel = movieListingItemViewModel;
            _moviesStore = moviesStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            Movie movie = _movieListingItemViewModel.Movie;

            EditMovieViewModel editMovieViewModel = new EditMovieViewModel(movie, _moviesStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editMovieViewModel;
        }
    }
}
