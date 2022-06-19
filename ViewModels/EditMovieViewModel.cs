using MyFavouritesWPF.Commands;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class EditMovieViewModel : ViewModelBase
    {
        public Guid MovieId { get; }

        public MovieDetailsFormModel MovieDetailsFormModel { get; }

        public EditMovieViewModel(Movie movie, MoviesStore _moviesStore, ModalNavigationStore modalNavigationStore)
        {
            MovieId = movie.Id;

            ICommand submitCommand = new SubmitEditMovieCommand(this, _moviesStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);

            MovieDetailsFormModel = new MovieDetailsFormModel(submitCommand, cancelCommand)
            {
                Name = movie.Name,
                Genre = movie.Genre,
                ReleaseYear = movie.ReleaseYear,
            };
        }
    }
}
