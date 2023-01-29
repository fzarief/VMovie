using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMovie
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Rating { get; set; }

        public Movie(int id, string title, decimal rating)
        {
            Id = id;
            Title = title;
            Rating = rating;
        }
    }
}
