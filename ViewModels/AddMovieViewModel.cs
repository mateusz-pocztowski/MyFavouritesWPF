using MyFavouritesWPF.Commands;
using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class AddMovieViewModel : ViewModelBase
    {
        public MovieDetailsFormModel MovieDetailsFormModel { get;  }

        public AddMovieViewModel(MoviesStore moviesStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new SubmitAddMovieCommand(this, moviesStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);

            MovieDetailsFormModel = new MovieDetailsFormModel(submitCommand, cancelCommand);
        }
    }
}
