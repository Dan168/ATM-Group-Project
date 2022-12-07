using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMForm
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        } 

        private void btnDone_Click(object sender, EventArgs e)
        {
            AccountHome a1 = new AccountHome();
            a1.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string selectedAcc = this.comboSelAcc.GetItemText(this.comboSelAcc.SelectedItem);
            double ammount = Convert.ToDouble(txtAmount.Text);

            if (selectedAcc.ToLower() == "simple")
            {
                Account a1 = new Account("1");
                a1.Deposit(ammount, 1);
            }
            if (selectedAcc.ToLower() == "current")
            {
                Account a1 = new Account("1");
                a1.Deposit(ammount, 2);
            }
        }
    }
}
