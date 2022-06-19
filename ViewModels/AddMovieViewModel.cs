using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.ViewModels
{
    public class AddMovieViewModel : ViewModelBase
    {
        public MovieDetailsFormModel MovieDetailsFormModel { get;  }

        public AddMovieViewModel()
        {
            MovieDetailsFormModel = new MovieDetailsFormModel();
        }
    }
}
