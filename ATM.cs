public class ATM
{
    private long cardNum;
    private int pin;
    
    //read card
    public void SetCard()
    {
        long demoNum = 8473525946758465;
        int demoPin = 1234;
        
        Card card = new Card(demoNum, demoPin);
        
        this.cardNum = card.GetCardNum();
        this.pin = card.GetPin();
    }
    
    //authenticate pin
    /*
    public bool AuthenticatePin(userInpt)
    {
        Card card = new Card(demoNum, demoPin);
        if (userInpt == card.GetPin())
        {
            
            
        }  
    }
    */
    //call functions to create account, deposit and withdraw.
}