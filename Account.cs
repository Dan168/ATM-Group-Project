public class Account
{
    private string custID;
    private int accountNumber;
    private string custName;
    private double accBalance;
    private double currentAccBalance;
    private double extendedAccBalance;

    public Account(int custId)
    {
        try
        {
            string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
        
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] fields = csvLines[i].Split(",");
                if (fields[0].Contains(Convert.ToString(custId)))
                {
                    this.custID = fields[0];
                    this.accountNumber = Convert.ToInt32(fields[5]);
                    this.custName = fields[1];
                    this.accBalance = Convert.ToDouble(fields[6]);
                    this.currentAccBalance = Convert.ToDouble(fields[8]);
                    this.extendedAccBalance = Convert.ToDouble(fields[10]);
                }
            }
        }
        catch
        {
            Console.WriteLine("We're sorry, something has gone wrong retrieving customer information. Please try again later.");
        }
    }

    public double GetBalance(int accountType)
    {
        //1 - stan 2- current 3- extended
        switch (accountType)
        {
            case(1):
                return accBalance;
            case(2):
                return currentAccBalance;
            case(3):
                return extendedAccBalance;
        }

        return 0;
    }

    public bool Withdraw(double amount)
    {
        string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
        for (int i = 0; i < csvLines.Length; i++)
        {
            try
            {
                string[] fields = csvLines[i].Split(",");
                if (!fields.Contains(custID))
                {
                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                     "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "\n";
                    File.AppendAllText("temp.csv", toWrite);
                }
                else
                {
                    double newBalance = Convert.ToDouble(fields[6]) - amount;
                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                     "," + fields[5] + "," + newBalance + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "\n";
                    File.AppendAllText("temp.csv", toWrite);
                }
            }
            catch
            {
                Console.WriteLine("Something has gone wrong withdrawing funds into the account. Please contact the bank.");
                return false;
            }
        }
        File.Delete("CUSTOMERS.csv");
        File.Move("temp.csv", "CUSTOMERS.csv");
        return true;
    
    }
    
    public bool Deposit(double amount)
    {
        string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
        for (int i = 0; i < csvLines.Length; i++)
        {
            try
            {
                string[] fields = csvLines[i].Split(",");
                if (!fields.Contains(custID))
                {
                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                     "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "\n";
                                     File.AppendAllText("temp.csv", toWrite);
                }
                else
                {
                    double newBalance = Convert.ToDouble(fields[6]) + amount;
                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                     "," + fields[5] + "," + newBalance + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "\n";
                                     File.AppendAllText("temp.csv", toWrite);
                }
            }
            catch
            {
                Console.WriteLine("Something has gone wrong depositing funds into the account. Please contact the bank.");
                return false;
            }
        }
        File.Delete("CUSTOMERS.csv");
        File.Move("temp.csv", "CUSTOMERS.csv");
        return true;
    }
}