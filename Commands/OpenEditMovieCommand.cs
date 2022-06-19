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
        private readonly Movie _movie;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditMovieCommand(Movie movie, ModalNavigationStore modalNavigationStore)
        {

            _movie = movie;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            EditMovieViewModel editMovieViewModel = new EditMovieViewModel(_movie, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editMovieViewModel;
        }
    }
}
