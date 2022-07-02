using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.EntityFramework.DTO
{
    public class MovieDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GenreDTO Genre { get; set; }
        public string ReleaseYear { get; set; }
    }
}
