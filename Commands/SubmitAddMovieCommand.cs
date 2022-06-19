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
    public class SubmitAddMovieCommand : AsyncCommandBase
    {
        private readonly AddMovieViewModel _addMovieViewModel;
        private readonly MoviesStore _moviesStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitAddMovieCommand(AddMovieViewModel addMovieViewModel, MoviesStore moviesStore, ModalNavigationStore modalNavigationStore)
        {
            _addMovieViewModel = addMovieViewModel;
            _moviesStore = moviesStore;
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            var formViewModel = _addMovieViewModel.MovieDetailsFormModel;

            Movie movie = new Movie(
                Guid.NewGuid(),
                formViewModel.Name,
                formViewModel.Genre,
                formViewModel.ReleaseYear
            );

            try
            {
                // TODO: add movie to database
                await _moviesStore.Add(movie);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
