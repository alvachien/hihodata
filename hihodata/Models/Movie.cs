using System;

namespace AlvaChien.HIH.OData.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTimeOffset ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public decimal Price { get; set; }
    }
}
