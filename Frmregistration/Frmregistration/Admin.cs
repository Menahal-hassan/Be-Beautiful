using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace frmregistration
{
    class Admin
    {
        private string adminname = "Maham";
        private string adminpassword = "123";
        private string adminaddress= "Iqbaltown";

        public string Adminname
        {
            get
            {
                return adminname;
            }

            set
            {
                adminname = value;
            }
        }

        public string Adminpassword
        {
            get
            {
                return adminpassword;
            }

            set
            {
                adminpassword = value;
            }
        }

        public string Adminaddress
        {
            get
            {
                return adminaddress;
            }

            set
            {
                adminaddress = value;
            }
        }
    }
}
