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
    public partial class ATMHome : Form
    {
        public ATMHome()
        {
            InitializeComponent();
            
            string[] csvLinesCard = File.ReadAllLines("CARDS.csv");

            List<string> cards = new List<string>();
            
            for (int i = 1; i < csvLinesCard.Length; i++)
            {
                string[] fields = csvLinesCard[i].Split(',');

                cards.Add(fields[0]);
            }

            comboBox1.DataSource = cards;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            pinBox.AppendText("9");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            pinBox.Text = ("");
        }
        int wrongAttept = 0;
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int userInptPin = Convert.ToInt32(pinBox.Text);
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            Card card = new Card(Convert.ToInt32(selected));

            if (wrongAttept > 3)
            {
                MessageBox.Show("Too many attempts.");
                card.LockCard();
            }
            else if (userInptPin == card.GetPin())
            {
                AccountHome f1 = new AccountHome();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Pin");
                wrongAttept++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pinBox_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
