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
    public partial class AccountHome : Form
    {
        public AccountHome()
        {
            InitializeComponent();
            Account a1 = new Account("1");
            simpleBalance.Text = Convert.ToString(a1.GetBalance(1));
            currentBalance.Text = Convert.ToString(a1.GetBalance(2));
            longBalance.Text = Convert.ToString(a1.GetBalance(3));
        }

        private void simpleBalance_Click(object sender, EventArgs e)
        {

        }

        private void currentBalance_Click(object sender, EventArgs e)
        {

        }

        private void longBalance_Click(object sender, EventArgs e)
        {

        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw w1 = new Withdraw();
            w1.Show();
            this.Hide();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            Deposit d1 = new Deposit();
            d1.Show();
            this.Hide();
        }

        private void BtnTrasnfer_Click(object sender, EventArgs e)
        {
            Transfer t1 = new Transfer();
            t1.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            ATMHome a1 = new ATMHome();
            a1.Show();
            this.Close();
        }
    }
}
