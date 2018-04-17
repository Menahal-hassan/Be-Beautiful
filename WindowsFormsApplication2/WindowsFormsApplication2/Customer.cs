using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Customer
    {
        private String custname ;
        private String custpassword;
        private String custaddress;
        private String custphone;
        private String custcity;

        public string Custname
        {
            get
            {
                return custname;
            }

            set
            {
                custname = value;
            }
        }

        public string Custpassword
        {
            get
            {
                return custpassword;
            }

            set
            {
                custpassword = value;
            }
        }

        public string Custaddress
        {
            get
            {
                return custaddress;
            }

            set
            {
                custaddress = value;
            }
        }

        public string Custphone
        {
            get
            {
                return custphone;
            }

            set
            {
                custphone = value;
            }
        }

        public string Custcity
        {
            get
            {
                return custcity;
            }

            set
            {
                custcity = value;
            }
        }
    }
    }
}
