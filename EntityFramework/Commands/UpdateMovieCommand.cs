using MyFavouritesWPF.EntityFramework.DTO;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework.Commands
{
    class UpdateMovieCommand : IUpdateMovieCommand
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public UpdateMovieCommand(MoviesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task Execute(Movie movie)
        {
            using (MoviesDbContext context = _contextFactory.Create())
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    Genre = new GenreDTO(movie.Genre.Id, movie.Genre.Name),
                    ReleaseYear = movie.ReleaseYear
                };

                context.Movies.Update(movieDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
