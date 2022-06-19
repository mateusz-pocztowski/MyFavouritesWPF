using MyFavouritesWPF.Stores;
using MyFavouritesWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.Commands
{
    public class OpenAddMovieCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddMovieCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddMovieViewModel addMovieViewModel = new AddMovieViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addMovieViewModel;
        }
    }
}
