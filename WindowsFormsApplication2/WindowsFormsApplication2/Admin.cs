using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Admin
    {
        private String adminname ;
        private String adminpassword;
        private String adminaddress;
        private String adminphone;

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

        public string Adminphone
        {
            get
            {
                return adminphone;
            }

            set
            {
                adminphone = value;
            }
        }
    }
}
