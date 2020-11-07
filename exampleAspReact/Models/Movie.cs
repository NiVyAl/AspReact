using System;
using System.ComponentModel.DataAnnotations;

namespace exampleAspReact.Models
{
	public class Movie
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public int LengthMinutes { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }
        //public decimal Price { get; set; }
    }
}
