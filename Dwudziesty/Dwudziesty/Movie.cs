using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwudziesty
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie( string Title, string Director, string rating)
        {
            this.title = Title;
            this.director = Director;
            Rating = rating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
