using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Queries
{
    public interface ICreateMovieCommand
    {
        Task Execute(Movie movie);
    }
}
