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
        string Title { get; set; }
        string Category { get; set; }
    }
}
