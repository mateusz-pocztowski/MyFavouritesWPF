using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Queries;
using MyFavouritesWPF.EntityFramework.DTO;

namespace MyFavouritesWPF.EntityFramework.Queries
{
    public class GetAllMoviesQuery : IGetAllMoviesQuery
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public GetAllMoviesQuery(MoviesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Movie>> Execute()
        {
            using(MoviesDbContext context = _contextFactory.Create())
            {
                IEnumerable<MovieDTO> moviesDTOs = await context.Movies.ToListAsync();

                return moviesDTOs.Select(y => new Movie(y.Id, y.Name, y.Genre, y.ReleaseYear));
            }
        }
    }
}
