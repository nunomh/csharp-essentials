using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial_freeCodeCamp
{
    internal class Song
    {
        public string name;
        public string artist;
        public static int songCount = 0;

        public Song(string aName, string aRating)
        {
            name = aName;
            artist = aRating;
            songCount++;
        }
    }
}
