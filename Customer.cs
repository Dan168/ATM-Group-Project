public class Customer
{
    private int custID;
    private string custName;
    private string custAddr;
    private string custPostcode;
    private DateTime custDob;
    //private int custAccountNum; - is this automatically assigned when creating an account?
    private string custOccupation;
    private decimal custAnnualIncome;
    
    public Customer(string custName, string custAddr, string custPostcode, DateTime custDob, string custOccupation, decimal custAnnualIncome)
    {
        this.custName = custName;
        this.custAddr = custAddr;
        this.custPostcode = custPostcode;
        this.custDob = custDob;
        this.custOccupation = custOccupation;
        this.custAnnualIncome = custAnnualIncome;
    }

    public string GetCustName()
    {
        return custName;
    }

    public bool CreateAccount()
    {
        //take cust details and save them to CSV
        return true;
    }

    public bool CreateCurrentAccount()
    {
        //take cust details and save them to CSV
        return true;
    }
}