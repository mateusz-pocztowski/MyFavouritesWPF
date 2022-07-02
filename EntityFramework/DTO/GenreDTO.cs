using System;
using System.ComponentModel.DataAnnotations;

namespace MyFavouritesWPF.EntityFramework.DTO
{
    public class GenreDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GenreDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
