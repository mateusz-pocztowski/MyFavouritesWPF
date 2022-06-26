using MyFavouritesWPF.Models;
using MyFavouritesWPF.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework.Queries
{
    public class GetAllMoviesQuery : IGetAllMoviesQuery
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public GetAllMoviesQuery(MoviesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Task<IEnumerable<Movie>> Execute()
        {
            using(MoviesDbContext context = _contextFactory.Create())
            {
                var moviesDTOs = context.Movies.ToList();

                return (Task<IEnumerable<Movie>>)moviesDTOs.Select(y => new Movie(y.Id, y.Name, y.Genre, y.ReleaseYear));
            }
        }
    }
}
