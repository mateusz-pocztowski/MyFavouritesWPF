using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Commands
{
    public class LoadMoviesCommand : AsyncCommandBase
    {
        private readonly MoviesStore _moviesStore;

        public LoadMoviesCommand(MoviesStore moviesStore)
        {
            _moviesStore = moviesStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            await _moviesStore.Load();
        }
    }
}
