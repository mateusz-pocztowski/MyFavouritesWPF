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
    public class SubmitEditMovieCommand : AsyncCommandBase
    {
        private readonly MoviesStore _moviesStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly EditMovieViewModel _editMovieViewModel;

        public SubmitEditMovieCommand(EditMovieViewModel editMovieViewModel, MoviesStore moviesStore, ModalNavigationStore modalNavigationStore)
        {
            _moviesStore = moviesStore;
            _modalNavigationStore = modalNavigationStore;
            _editMovieViewModel = editMovieViewModel;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            var formViewModel = _editMovieViewModel.MovieDetailsFormModel;

            Movie movie = new Movie(
                _editMovieViewModel.MovieId,
                formViewModel.Name,
                formViewModel.Genre,
                formViewModel.ReleaseYear
            );

            try
            {
                await _moviesStore.Update(movie);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
