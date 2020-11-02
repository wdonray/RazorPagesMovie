using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // Field is required by the database for the primary key
        public int ID {get; set;}
        // Title of the movie
        public string Title {get; set;}

        // The user is not required to enter time information in the date field.
        // Only the date is displayed, not time information.
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        public string Genre {get; set;}
        public decimal Price {get; set;}
    }
}