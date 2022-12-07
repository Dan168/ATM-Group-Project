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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnViewCust_Click(object sender, EventArgs e)
        {
            custLookup c1 = new custLookup();
            c1.Show();
        }

        private void btnChangeOD_Click(object sender, EventArgs e)
        {
            ChangeOD c2 = new ChangeOD();
            c2.Show();
        }

        private void btnUnlockCard_Click(object sender, EventArgs e)
        {
            UnlockCard u1 = new UnlockCard();
            u1.Show();
        }
    }
}
