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
    public partial class ChangeOD : Form
    {
        public ChangeOD()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string newOD = textBox2.Text;

            string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
            for (int i = 0; i < csvLines.Length; i++)
            {
                try
                {
                    string[] fields = csvLines[i].Split(',');
                    if (!fields[0].Contains(Convert.ToString(ID)))
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "," + "\n";
                        File.AppendAllText("temp.csv", toWrite);
                    }
                    else
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + newOD + "," + "\n";
                        File.AppendAllText("temp.csv", toWrite);
                    }
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            File.Delete("CUSTOMERS.csv");
            File.Move("temp.csv", "CUSTOMERS.csv");
            MessageBox.Show("Overdraft limit changed sucessfully.");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
