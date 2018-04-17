using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace frmregistration
{
    class AdminDL
    {
        public static List<Admin> admin = new List<Admin>();
        public void Addadmin()
        {

            Admin n = new Admin();
            admin.Add(n);
        }
    }
}
