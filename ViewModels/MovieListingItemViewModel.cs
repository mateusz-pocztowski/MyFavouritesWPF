using MyFavouritesWPF.Models;
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
        public Movie Movie { get; }

        public string Name => Movie.Name;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public MovieListingItemViewModel(Movie movie, ICommand editCommand)
        {
            Movie = movie;
            EditCommand = editCommand;
        }
    }
}
