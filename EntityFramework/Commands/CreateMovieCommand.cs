using MyFavouritesWPF.EntityFramework.DTO;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Queries;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework.Commands
{
    public class CreateMovieCommand : ICreateMovieCommand
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public CreateMovieCommand(MoviesDbContextFactory contextFactory)
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
                    Genre = movie.Genre,
                    ReleaseYear = movie.ReleaseYear
                };

                context.Movies.Add(movieDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
