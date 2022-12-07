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
    public partial class UnlockCard : Form
    {
        public UnlockCard()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;

            string[] csvLines = File.ReadAllLines("CARDS.csv");
            for (int i = 0; i < csvLines.Length; i++)
            {
                try
                {
                    string[] fields = csvLines[i].Split(',');
                    if (!fields[2].Contains(Convert.ToString(ID)))
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + "\n";
                        File.AppendAllText("temp.csv", toWrite);
                    }
                    else
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + "FALSE" + "," + "\n";
                        File.AppendAllText("temp.csv", toWrite);
                    }
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            File.Delete("CARDS.csv");
            File.Move("temp.csv", "CARDS.csv");
            MessageBox.Show("Account unlocked sucessuflly");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
