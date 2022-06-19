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
        public MovieDetailsFormModel MovieDetailsFormModel { get; }

        public EditMovieViewModel(Movie movie, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new SubmitAddMovieCommand(modalNavigationStore);
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
