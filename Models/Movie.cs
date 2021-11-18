using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp_movies_mvc.Models
{
    public enum Genres
    {
        comedy,
        Drama
    }
    public class Movie
    {
        [Key]
        public int id { get; set; }
       
        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; } = Genres.Drama;

        [Range(5.99, 7.99), Required]
        public decimal Price { get; set; }

    }
}
