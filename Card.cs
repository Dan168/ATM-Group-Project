using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMForm
{
    internal class Card
    {
        private long cardNum;
        private int pin;

        public Card(long cardNum)
        {
            this.cardNum = cardNum;

            string[] csvLinesCard = File.ReadAllLines("CARDS.csv");

            for (int i = 1; i < csvLinesCard.Length; i++)
            {
                string[] fields = csvLinesCard[i].Split(',');
                if (csvLinesCard[i].Contains(Convert.ToString(cardNum)))
                {
                    this.pin = Convert.ToInt32(fields[1]);
                }
            }
        }

        public long GetCardNum()
        {
            return this.cardNum;
        }

        public int GetPin()
        {
            return this.pin;
        }

        public void LockCard()
        {
            string[] csvLinesLock = File.ReadAllLines("CARDS.csv");
            for (int i = 1; i < csvLinesLock.Length; i++)
            {
                try
                {
                    string[] fields = csvLinesLock[i].Split(',');
                    if (!fields[0].Contains(Convert.ToString(cardNum)))
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + "\n";
                        File.AppendAllText("temp.csv", toWrite);
                    }
                    else
                    {
                        string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + "TRUE" + "," + "\n";
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
            
        }
    }
}
