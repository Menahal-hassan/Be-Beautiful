using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Product
    {
        private String productname;
        private String productcompany;
        private int productprice;

        public string Productname
        {
            get
            {
                return productname;
            }

            set
            {
                productname = value;
            }
        }

        public string Productcompany
        {
            get
            {
                return productcompany;
            }

            set
            {
                productcompany = value;
            }
        }
    }
}
