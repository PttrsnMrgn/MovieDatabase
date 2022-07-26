using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        //constructor
        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

        //properties
        public string Title { get; set; }
        public string Category { get; set; }
    }
}
