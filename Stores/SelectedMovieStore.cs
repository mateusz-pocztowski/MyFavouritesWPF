using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Stores
{
    public class SelectedMovieStore
    {
        private Movie _selectedMovie;

        public Movie selectedMovie
        {
            get
            {
                return _selectedMovie;
            }
            set
            {
                _selectedMovie = value;
                SelectedMovieChanged?.Invoke();
            }
        }

        public event Action SelectedMovieChanged;
    }
}
