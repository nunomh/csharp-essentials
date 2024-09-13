using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial_freeCodeCamp
{
    internal class Movie
    {
        public string title; // class attributes
        public string author;
        public int rating;

        // Constructor (não obrigatório, no entanto pode ser usado de forma a criar objectos mais facilmente,
        // em vez de especificar parametro a parametro, os parametros são todos passados neste metodo)
        public Movie(string aTitle, string aAuthor, int aRating)
        {
            title = aTitle;
            author = aAuthor;
            rating = aRating;
        }

        // Object Method
        public bool TestMethod()
        {
            if (title == null) { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
