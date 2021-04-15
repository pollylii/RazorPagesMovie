/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
    }
}
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    //public class Movie
    //{
    //    public int ID { get; set; }
    //    public string Title { get; set; }

    //    [DataType(DataType.Date)]
    //    public DateTime ReleaseDate { get; set; }
    //    public string Genre { get; set; }
    //    public decimal Price { get; set; }
    //    public string Rating { get; set; }
    //}
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        //[Range(1, 100), DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }
    }
}
