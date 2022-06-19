using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        public MovieViewModel MovieViewModel { get; }

        public MainViewModel(ModalNavigationStore modalNavigationStore, MovieViewModel movieViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            MovieViewModel = movieViewModel;
        }
    }
}
