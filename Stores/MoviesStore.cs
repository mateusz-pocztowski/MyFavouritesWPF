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
        public event Action<Movie> MovieUpdated;

        public async Task Add(Movie movie)
        {
            MovieAdded?.Invoke(movie);
        }
        public async Task Update(Movie movie)
        {
            MovieUpdated?.Invoke(movie);
        }
    }
}
