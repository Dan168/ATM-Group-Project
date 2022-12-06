public class CurrentAccount : Account
{
    private double overdraftLimit;
    
    public CurrentAccount(int custId) : base(custId)
    {
        //we need to retrive the overdraft limit 
        try
        {
            string[] csvLines = File.ReadAllLines("CUSTOMERS.csv");
        
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] fields = csvLines[i].Split(",");
                if (fields[0].Contains(Convert.ToString(custId)))
                {
                    overdraftLimit = Convert.ToDouble(fields[11]);
                }
            }
        }
        catch
        {
            Console.WriteLine("We're sorry, something has gone wrong retrieving customer information. Please try again later.");
        }
    }

    public double GetOverdraftLimit()
    {
        return overdraftLimit;
    }

    
}