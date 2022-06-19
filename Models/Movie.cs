using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Models
{
    public class Movie
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Genre { get; }
        public string ReleaseYear { get; }

        public Movie(Guid id, string name, string genre, string releaseYear)
        {
            Id = id;
            Name = name;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
    }
}
