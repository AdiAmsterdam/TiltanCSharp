namespace WarCardGame;

public class Deck
{
    private Queue<Card> deck;
    Random random = new Random();
    //Create 2 constructors - one for a full deck one for an empty deck
   /* public Deck()
    {
        deck = new Queue<Card>();
    }
*/
    public Deck()
    {
        CreateDeck();
    }
    void CreateDeck()
    {
        deck = new Queue<Card>();
        for (int s = 1; s <= 4; s++)
        {
            for (int v = 2; v <= 15; v++)
            {
                Card card = new Card(v, s);
                if (!this.deck.Contains(card)) this.deck.Enqueue(card);
            }
        }
    }

    public void ShowDeck() //make this a comment before submitting
    {
        Console.WriteLine(this.deck.Count);
        while (this.deck.Count > 0)
        {
            this.deck.Dequeue().ShowCard();
        }
    }

    public void ArrangePlayersDecks(out Deck deck1, out Deck deck2) //Fills both decks with the same number of cards
    {
        deck1 = new Deck();
        deck2 = new Deck();
    }
    public void ShuffleDeck() //Create a shuffle method and make it private FIX IT!!!!!
    {
        return;
    }

    public void ShuffleCards(Card card1, Card card2) //Shuffle two cards back to the winning deck
    {
        return;
    }

    public Card DrawCard()
    {
        Console.WriteLine("Card Drawn: ");
        return this.deck.Dequeue();
    }

    public void AddCard(Card card)
    {
        this.deck.Enqueue(card);
    }

    public int Count()
    {
        return this.deck.Count;
    }
}