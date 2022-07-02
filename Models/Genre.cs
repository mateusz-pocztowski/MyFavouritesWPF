using System;
using System.Collections.Generic;

namespace MyFavouritesWPF.Models
{
    public class Genre
    {
        public Guid Id { get; }
        public string Name { get; }
        public List<Movie> Movies { get; }
        public Genre(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}