using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace frmregistration
{
    class MakeupArtistDl
    {
        public static List<MakeupArtist> makeupArtists = new List<MakeupArtist>();
        public void addmakeupartist(MakeupArtist m)
        {
            MakeupArtist m1 = new MakeupArtist();
            m1.Makename = m.Makename;
            m1.Makepassword = m.Makepassword;
            m1.Makephone = m.Makephone;
            m1.Makeaddress = m.Makeaddress;
            makeupArtists.Add(m1);
            MessageBox.Show("MakeupArtist registered ");

        }
    }
}
