public class Card
{
    private long cardNumber;
    private int pin;

    public Card(long cardNumber, int pin)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
    }

    public long GetCardNum()
    {
        return cardNumber;
    }

    public int GetPin()
    {
        return pin;
    }

   
    //new instance of card is made when inserted to the machine 
    //the card number refers to the account in the main database 
}