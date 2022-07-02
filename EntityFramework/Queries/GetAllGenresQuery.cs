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
    public class GetAllGenresQuery : IGetAllGenresQuery
    {
        private readonly MoviesDbContextFactory _contextFactory;

        public GetAllGenresQuery(MoviesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Genre>> Execute()
        {
            using(MoviesDbContext context = _contextFactory.Create())
            {
                IEnumerable<GenreDTO> genresDTOs = await context.Genres.ToListAsync();

                return genresDTOs.Select(g => new Genre(g.Id, g.Name));
            }
        }
    }
}
