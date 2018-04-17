using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace frmregistration
{
    class CustomerDl
    {
        public static List<Customer> Customers = new List<Customer>();
        public void addcust(Customer c)
        {
            Customer m = new Customer();
            m.Custname = c.Custname;
            m.Custpassword = c.Custpassword;
            m.Custphone = c.Custphone;
            m.Custaddress = c.Custaddress;
            Customers.Add(m);
            MessageBox.Show("Customer registered ");
        }
    }
}
