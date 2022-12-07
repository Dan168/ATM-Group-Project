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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string selectedAccFrom = this.comboSelAccFrom.GetItemText(this.comboSelAccFrom.SelectedItem);
            string selectedAccTo = this.comboSelecAccTo.GetItemText(this.comboSelecAccTo.SelectedItem);

            double ammount = Convert.ToDouble(txtAmount.Text);

            int from = 0;
            int to = 0;

            if (selectedAccFrom.ToLower() == "simple")
            {
                from = 1;
            }
            if (selectedAccFrom.ToLower() == "current")
            {
                from = 2;

            }


            if (selectedAccTo.ToLower() == "simple")
            {
                to = 1;
            }
            if (selectedAccTo.ToLower() == "current")
            {
                to = 2;
            }

            Account a2 = new Account("1");
            a2.Transfer(from, to, ammount);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            AccountHome a1 = new AccountHome();
            a1.Show();
            this.Hide();
        }
    }
}
