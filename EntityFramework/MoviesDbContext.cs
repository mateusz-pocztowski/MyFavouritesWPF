using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFavouritesWPF.EntityFramework.DTO;

namespace MyFavouritesWPF.EntityFramework
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<MovieDTO> Movies { get; set; }
        public DbSet<GenreDTO> Genres { get; set; }
    }
}
