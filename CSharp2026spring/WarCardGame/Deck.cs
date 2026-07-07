namespace WarCardGame;

public class Deck
{
    private static int cardShapeAmount = 4;
    private static int cardValueAmount = 15;
    private Queue<Card> deck;
    Random random = new Random();
    
    //Create 2 constructors - one for a full deck one for an empty deck
    public Deck()
    {
        deck = new Queue<Card>();
    }
    public Deck(bool fullDeck)
    {
        if (fullDeck) CreateDeck();
    }
    private void CreateDeck()
    {
        deck = new Queue<Card>();
        for (int s = 1; s <= cardShapeAmount; s++)
        {
            for (int v = 2; v <= cardValueAmount; v++)
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
    public void ShuffleDeck() //Shuffles the cards
    {
        int shuffleCount = random.Next(5, 20);
        Deck deck1 = new Deck();
        Deck deck2 = new Deck();
        Deck deck3 = new Deck();
        for (int i = 1; i < shuffleCount; i++)
        {
            while (this.deck.Count > 0)
            {
                deck1.AddCard(DrawCard());
                deck2.AddCard(DrawCard());
                deck3.AddCard(DrawCard());
            }

            EmptyToDeck(deck2);
            EmptyToDeck(deck3);
            EmptyToDeck(deck1);
        }
    }

    private void EmptyToDeck(Deck deck1)//Empties a given deck to this deck
    {
        while (deck1.Count() > 0)
        {
            AddCard(deck1.DrawCard());
        }
    }

    public void ShuffleCards(Card card1, Card card2) //Shuffle two cards back to the winning deck
    {
        return;
    }

    public Card DrawCard()//Draws a card
    {
        return this.deck.Dequeue();
    }

    public void AddCard(Card card)//Adds a given card to the deck
    {
        this.deck.Enqueue(card);
    }

    public int Count()//Returns the number of cards in the deck
    {
        return this.deck.Count;
    }
}