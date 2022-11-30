namespace ATMClasses;

public class Card
{
    private int cardNumber;
    private int pin;

    public Card(int cardNumber, int pin)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
    }
    
    //new instance of card is made when inserted to the machine 
    //the card number refers to the account in the main database 
}