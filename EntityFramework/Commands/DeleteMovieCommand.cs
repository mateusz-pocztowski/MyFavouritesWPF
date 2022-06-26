using MyFavouritesWPF.EntityFramework.DTO;
using MyFavouritesWPF.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework.Commands
{
    class DeleteMovieCommand: IDeleteMovieCommand
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public DeleteMovieCommand(MoviesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task Execute(Guid id)
        {
            using (MoviesDbContext context = _contextFactory.Create())
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    Id = id,
                };

                context.Movies.Remove(movieDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
