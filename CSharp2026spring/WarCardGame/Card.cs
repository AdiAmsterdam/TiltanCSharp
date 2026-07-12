namespace WarCardGame;

public struct Card
{
    private CardValue cardValue{get;}
    private CardShape? cardShape{get;}
    private CardColor cardColor{get;}

    public Card(int value, int shape) //Card constructor
    {
        this.cardValue = (CardValue)value;
        
        if (this.cardValue == CardValue.Joker)
        {
            this.cardShape = null;
        }
        else
        {
            this.cardShape = (CardShape)shape;
        }
        
        if (shape == 1 || shape == 2) this.cardColor = CardColor.Red;
        else this.cardColor = CardColor.Black;
       
    }

    public void ShowCard()//Shows the card
    {
        if (this.cardValue == CardValue.Joker)
        {
            Console.WriteLine($"{this.cardColor} {this.cardValue}");
        }
        else Console.WriteLine($"{this.cardValue} of {this.cardShape}");
    }

    public int getCardValueHash()// Gets the hash code for the card value enum
    {
        return cardValue.GetHashCode();
    }
}