using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMForm
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            string[] csvLines = File.ReadAllLines("ADMIN.csv");

            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] fields = csvLines[i].Split(',');
                if (csvLines[i].Contains(username) && csvLines[i].Contains(password))
                {
                    //open the admin panel
                    AdminPanel a1 = new AdminPanel();
                    a1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
