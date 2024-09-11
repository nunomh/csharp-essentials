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

        // Constructor (não obrigatório, no entanto pode ser usado de forma a criar objectos mais facilmente,
        // em vez de especificar parametro a parametro, os parametros são todos passados neste metodo)
        public Movie(string aTitle, string aAuthor)
        {
            title = aTitle;
            author = aAuthor;
        }
    }
}
