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
    public class MovieViewModel : ViewModelBase
    {
        public MovieListingViewModel MovieListingViewModel { get; }
        public MovieDetailsViewModel MovieDetailsViewModel { get; }

        public ICommand AddMovieCommand { get; }

        public MovieViewModel(MoviesStore moviesStore, SelectedMovieStore selectedMovieStore, ModalNavigationStore modalNavigationStore)
        {
            MovieListingViewModel = MovieListingViewModel.LoadViewModel(moviesStore, selectedMovieStore, modalNavigationStore);
            MovieDetailsViewModel = new MovieDetailsViewModel(selectedMovieStore);

            AddMovieCommand = new OpenAddMovieCommand(moviesStore, modalNavigationStore);
        }
    }
}
