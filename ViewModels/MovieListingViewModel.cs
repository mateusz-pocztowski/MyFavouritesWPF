using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<MovieListingItemViewModel> _movieListingItemViewModels;

        public IEnumerable<MovieListingItemViewModel> MovieListingItemViewModels => _movieListingItemViewModels;

        public MovieListingViewModel()
        {
            _movieListingItemViewModels = new ObservableCollection<MovieListingItemViewModel>();

            _movieListingItemViewModels.Add(new MovieListingItemViewModel("Movie 1"));
            _movieListingItemViewModels.Add(new MovieListingItemViewModel("Movie 2"));
            _movieListingItemViewModels.Add(new MovieListingItemViewModel("Movie 3"));
        }
    }
}
