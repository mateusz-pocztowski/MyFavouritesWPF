using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Models
{
    public class Movie
    {
        public string Name { get; }
        public string Genre { get; }
        public string ReleaseYear { get; }

        public Movie(string name, string genre, string releaseYear)
        {
            Name = name;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
    }
}
