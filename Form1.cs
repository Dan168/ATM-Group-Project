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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin a1 = new AdminLogin();
            a1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ATMHome f1 = new ATMHome();
            f1.Show();
            //this.Close();
        }
    }
}
