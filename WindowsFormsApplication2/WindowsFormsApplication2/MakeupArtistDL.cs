using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class MakeupArtistDL
    {
        public static List<MakeupArtist> artists = new List<MakeupArtist>;
        public bool isvalidmake(string username, string password);
        public void Addartists();
        public int confirmcall();
        public int totalbill();
        
    }
}
