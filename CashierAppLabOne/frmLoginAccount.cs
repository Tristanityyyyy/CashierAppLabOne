using ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierAppLabOne
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cs = new Cashier("Tristan Labjata", usernBox.Text, passwBox.Text);

            if (cs.validateLogin(usernBox.Text, passwBox.Text).Equals(true))
            {
                MessageBox.Show("Welcome " + cs.getFullName() + " of " + cs.getDepartment());
                frmLoginAccount frmLoginAccount = new frmLoginAccount();
                this.Close();
            }
            else{
                MessageBox.Show("Sorry account doesn't exist.");
            }


        }
    }
}
