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
    public class EditMovieViewModel : ViewModelBase
    {
        public MovieDetailsFormModel MovieDetailsFormModel { get; }

        public EditMovieViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            MovieDetailsFormModel = new MovieDetailsFormModel(null, cancelCommand);
        }
    }
}
