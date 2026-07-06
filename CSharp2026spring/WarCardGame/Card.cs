namespace WarCardGame;

public struct Card
{
    private Value value{get;}
    private Shape? shape{get;}
    private Color color{get;}

    public Card(int value, int shape)
    {
        this.value = (Value)value;
        
        if (this.value == Value.Joker)
        {
            this.shape = null;
        }
        else
        {
            this.shape = (Shape)shape;
        }
        
        if (shape == 1 || shape == 2) this.color = Color.Red;
        else this.color = Color.Black;
       
    }

    public void ShowCard()
    {
        if (this.value == Value.Joker)
        {
            Console.WriteLine($"{this.color} {this.value}");
        }
        else Console.WriteLine($"{this.value} of {this.shape}");
    }
}