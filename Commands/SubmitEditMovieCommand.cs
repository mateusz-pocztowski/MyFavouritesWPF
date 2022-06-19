using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Commands
{
    public class SubmitEditMovieCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public SubmitEditMovieCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            // TODO: edit movie in database

            _modalNavigationStore.Close();
        }
    }
}
