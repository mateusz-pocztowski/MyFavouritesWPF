using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFavouritesWPF.EntityFramework.DTO;
using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework
{
    public class GenreConfiguration 
    {
        public static void Configure(MoviesDbContext context)
        {
            context.Database.EnsureCreated();

            int count = context.Genres.Count();

            if(count == 0)
            {
                List<GenreDTO> genres = new List<GenreDTO>() {
                    new GenreDTO(new Guid(), "Comedy"),
                    new GenreDTO(new Guid(), "Action"),
                    new GenreDTO(new Guid(), "Drama"),
                    new GenreDTO(new Guid(), "Fantasy"),
                    new GenreDTO(new Guid(), "Mystery"),
                    new GenreDTO(new Guid(), "Romance"),
                    new GenreDTO(new Guid(), "Thriller"),
                    new GenreDTO(new Guid(), "Sci-fi"),
                    new GenreDTO(new Guid(), "Horror")
                };

                context.Genres.AddRange(genres);
                context.SaveChanges();
            }
        }
    }
}
