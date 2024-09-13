using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial_freeCodeCamp
{
    internal class MetalSong : Song
    {
        public string subgenre;
        public MetalSong(string aName, string aRating, string aSubgenre) : base(aName, aRating)
        {
            this.subgenre = aSubgenre;
        }
    }
}
