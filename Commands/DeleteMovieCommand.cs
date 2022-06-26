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
    public class DeleteMovieCommand : AsyncCommandBase
    {
        private readonly MoviesStore _moviesStore;
        private readonly MovieListingItemViewModel _movieListingItemViewModel;

        public DeleteMovieCommand(MovieListingItemViewModel movieListingItemViewModel, MoviesStore moviesStore)
        {
            _movieListingItemViewModel = movieListingItemViewModel;
            _moviesStore = moviesStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Movie movie = _movieListingItemViewModel.Movie;

            await _moviesStore.Delete(movie.Id);
        }
    }
}
