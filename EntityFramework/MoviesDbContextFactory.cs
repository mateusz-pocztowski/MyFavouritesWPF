using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework
{
    public class MoviesDbContextFactory
    {
        private readonly DbContextOptions _options;

        public MoviesDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public MoviesDbContext Create()
        {
            return new MoviesDbContext(_options);
        }

    }
}
