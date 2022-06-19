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
        public string Name { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public MovieListingItemViewModel(string name)
        {
            Name = name;
        }
    }
}
