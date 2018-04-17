using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmregistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void cmdregister_Click(object sender, EventArgs e)
        {
            Server1.Service1 myserver = new Server1.Service1();
            if (admin.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addadmin(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Admin registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }
            else if (customer.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addcustomer(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Customer registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }
            else if (makeupArtist.Checked)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    myserver.Addmakeupartist(txtusername.Text, txtpassword.Text, txtphonenumber.Text, txtaddress.Text);
                    MessageBox.Show("Makeup Artist registered");
                }
                else
                {
                    MessageBox.Show("passsword does not match");
                }

            }

        }
    }
}
