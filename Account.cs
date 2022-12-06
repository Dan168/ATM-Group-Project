public class Account
{
    private string custID;
    private int accountNumber;
    private string custName;
    private double accBalance;
    private double currentAccBalance;
    private double extendedAccBalance;
    private double overdraftLimit;

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

    public void Withdraw(double amount, int accountType)
    //Change these so that the account type has to be selected ... instead of using virtual method in each class
    {
        amount = -10;
        switch(accountType)
        {
            //Simple account 
            case(1):
                string[] csvLinesSimple = File.ReadAllLines("CUSTOMERS.csv");
                for (int i = 0; i < csvLinesSimple.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLinesSimple[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[6]) - amount;
                            if (amount < 0)
                            {
                                Console.WriteLine("Sorry, there is not enough funds in your account.");
                                break;
                            }
                            else
                            {
                                string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                                 "," + fields[5] + "," + newBalance + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                                File.AppendAllText("temp.csv", toWrite);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Something has gone wrong withdrawing funds into the account. Please contact the bank.");
                    }
                }
                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;
            
            //Current account
            case(2):
                string[] csvLinesCurrent = File.ReadAllLines("CUSTOMERS.csv");
                for (int i = 0; i < csvLinesCurrent.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLinesCurrent[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[8]) - amount;
                            //Console.WriteLine(fields[8]);
                            //Console.WriteLine(newBalance);

                            if (newBalance < 0)
                            {
                                double limitWithOD = Convert.ToDouble(fields[11]) - (Convert.ToDouble(fields[11]) * 2);
                                if (newBalance < limitWithOD)
                                {
                                    Console.WriteLine("You have gone past your overdraft limit. Transaction was not approved.");
                                    
                                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                                     "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                                    File.AppendAllText("temp.csv", toWrite);
                                    break;
                                }
                                else
                                {
                                    string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + newBalance + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                                    File.AppendAllText("temp.csv", toWrite);
                                }
                            }
                            else
                            {
                                string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                                 "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + newBalance + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                                File.AppendAllText("temp.csv", toWrite);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Something has gone wrong withdrawing funds into the account. Please contact the bank.");
                    }
                }
                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;
            
            case(3):
                string[] csvLinesSpecial = File.ReadAllLines("CUSTOMERS.csv");
                for (int i = 0; i < csvLinesSpecial.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLinesSpecial[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[10]) - amount;
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] +
                                             "," + fields[5] + "," + newBalance + "," + fields[7] + "," + fields[8] + "," + fields[9] + "," + newBalance + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Something has gone wrong withdrawing funds into the account. Please contact the bank.");
                    }
                }
                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;
        }
    }

    public void Deposit(double amount, int accountType)
    {
        string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
        switch (accountType)
        {
            case (1): //Simple account 
                for (int i = 0; i < csvLines.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLines[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] +
                                             "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[6]) + amount;
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + newBalance + "," + fields[7] + "," + fields[8] +
                                             "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(
                            "Something has gone wrong depositing funds into the account. Please contact the bank.");
                    }
                }

                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;

            case (2): //Current account
                for (int i = 0; i < csvLines.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLines[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] +
                                             "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[8]) + amount;
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + newBalance +
                                             "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(
                            "Something has gone wrong depositing funds into the account. Please contact the bank.");
                    }
                }

                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;

            case (3): //Long account
                for (int i = 0; i < csvLines.Length; i++)
                {
                    try
                    {
                        string[] fields = csvLines[i].Split(",");
                        if (!fields.Contains(custID))
                        {
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] +
                                             "," + fields[9] + "," + fields[10] + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                        else
                        {
                            double newBalance = Convert.ToDouble(fields[10]) + amount;
                            string toWrite = fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," +
                                             fields[4] +
                                             "," + fields[5] + "," + fields[6] + "," + fields[7] + "," + fields[8] +
                                             "," + fields[9] + "," + newBalance + "," + fields[11] + "\n";
                            File.AppendAllText("temp.csv", toWrite);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(
                            "Something has gone wrong depositing funds into the account. Please contact the bank.");
                    }
                }

                File.Delete("CUSTOMERS.csv");
                File.Move("temp.csv", "CUSTOMERS.csv");
                break;
        }
    }
    
        public void Transfer(int fromAccount, int toAccount, double ammount)
        {
            //withdraw from fromAccount and deposit to toAccount
            try
            {
                Withdraw(ammount, fromAccount);
                Deposit(ammount, toAccount);
            }
            catch
            {
                Console.WriteLine("An error has occoured while transfering funds. Please ensure there is enough money in the account the complete the transfer.");
            }
        }
}
