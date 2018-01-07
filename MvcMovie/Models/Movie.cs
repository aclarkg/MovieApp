using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        
       // [DataType(DataType.Date)]
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}