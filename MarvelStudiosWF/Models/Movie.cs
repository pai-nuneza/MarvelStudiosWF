using System;

namespace MarvelStudiosWF.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Director { get; set; }
        public decimal Budget{ get; set; }
    
    }
}
