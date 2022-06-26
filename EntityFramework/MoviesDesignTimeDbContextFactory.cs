using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework
{
    public class MoviesDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MoviesDbContext>
    {
        public MoviesDbContext CreateDbContext(string[] args = null)
        {
            return new MoviesDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=Movies.db").Options);
        }

    }
}
