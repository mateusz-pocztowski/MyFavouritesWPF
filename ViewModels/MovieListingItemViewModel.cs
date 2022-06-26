using MyFavouritesWPF.Commands;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieListingItemViewModel : ViewModelBase
    {
        public Movie Movie { get; private set; }

        public string Name => Movie.Name;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public MovieListingItemViewModel(Movie movie, MoviesStore _moviesStore, ModalNavigationStore modalNavigationStore)
        {
            Movie = movie;

            EditCommand = new OpenEditMovieCommand(this, _moviesStore, modalNavigationStore);
            DeleteCommand = new DeleteMovieCommand(this, _moviesStore);
        }

        public void Update(Movie movie)
        {
            Movie = movie;

            OnPropertyChanged(nameof(Name));
        }
    }
}
