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
    public partial class custLookup : Form
    {
        public custLookup()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;

            string[] csvLinesLock = File.ReadAllLines("CUSTOMERS.csv");
            for (int i = 1; i < csvLinesLock.Length; i++)
            {
                try
                {
                    string[] fields = csvLinesLock[i].Split(',');
                    if (fields[0].Contains(Convert.ToString(ID)))
                    {
                        MessageBox.Show($"Name: {fields[1]} \nDOB: {fields[2]} \nEmail: {fields[3]} \nPostcode: {fields[4]} \nSimple account number: {fields[5]} \nAccount balance: {fields[6]} \nCurrent account number: {fields[7]} \nCurrent account balance: {fields[8]} \nExtended account number: {fields[9]} \nExtended account balance: {fields[10]} \nOverdraft Limit: {fields[11]}");
                    }
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
