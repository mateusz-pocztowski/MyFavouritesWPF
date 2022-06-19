using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Stores
{
    public class MoviesStore
    {
        public event Action<Movie> MovieAdded;

        public async Task Add(Movie movie)
        {
            MovieAdded?.Invoke(movie);
        }
    }
}
