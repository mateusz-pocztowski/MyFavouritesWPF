using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Queries
{
    public interface IDeleteMovieCommand
    {
        Task Execute(Guid id);
    }
}
