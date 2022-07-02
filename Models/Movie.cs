using System;

namespace MyFavouritesWPF.Models
{
    public class Movie
    {
        public Guid Id { get; }
        public string Name { get; }
        public Guid GenreId { get; }
        public Genre Genre { get; }
        public string ReleaseYear { get; }

        public Movie(Guid id, string name, Genre genre, string releaseYear)
        {
            Id = id;
            Name = name;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
    }
}