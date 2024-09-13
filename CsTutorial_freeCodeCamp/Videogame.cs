using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial_freeCodeCamp
{
    internal class Videogame
    {
        // Getters and Setters

        public string name;
        private string rating;

        public Videogame(string aName, string aRating) {
            name = aName;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13") { 
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
