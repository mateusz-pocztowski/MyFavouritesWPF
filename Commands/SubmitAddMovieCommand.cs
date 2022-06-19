using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Commands
{
    public class SubmitAddMovieCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitAddMovieCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            // TODO: add movie to database

            _modalNavigationStore.Close();
        }
    }
}
