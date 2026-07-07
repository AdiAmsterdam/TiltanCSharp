namespace WarCardGame;

public struct Card
{
    private CardValue value{get;}
    private CardShape? shape{get;}
    private CardColor color{get;}

    public Card(int value, int shape)
    {
        this.value = (CardValue)value;
        
        if (this.value == CardValue.Joker)
        {
            this.shape = null;
        }
        else
        {
            this.shape = (CardShape)shape;
        }
        
        if (shape == 1 || shape == 2) this.color = CardColor.Red;
        else this.color = CardColor.Black;
       
    }

    public void ShowCard()//Shows the card
    {
        if (this.value == CardValue.Joker)
        {
            Console.WriteLine($"{this.color} {this.value}");
        }
        else Console.WriteLine($"{this.value} of {this.shape}");
    }
}