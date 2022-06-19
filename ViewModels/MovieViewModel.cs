using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieViewModel : ViewModelBase
    {
        public MovieListingViewModel MovieListingViewModel { get; }
        public MovieDetailsViewModel MovieDetailsViewModel { get; }

        public ICommand AddMovieCommand { get; }

        public MovieViewModel()
        {
            MovieListingViewModel = new MovieListingViewModel();
            MovieDetailsViewModel = new MovieDetailsViewModel();
        }
    }
}
