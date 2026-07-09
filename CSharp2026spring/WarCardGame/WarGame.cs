namespace WarCardGame;

public class WarGame
{
    private Deck fullDeck;
    private Deck yourDeck;
    private Deck opponentDeck;
    public void InitWarGame()//Initiates the game
    {
        Console.WriteLine("Welcome to War Card Game!");
        fullDeck = new Deck(true);
        fullDeck.ShuffleDeck();
        yourDeck = new Deck();
        opponentDeck = new Deck();
        fullDeck.ArrangePlayersDecks(yourDeck, opponentDeck);
        PlayTurn(yourDeck, opponentDeck);
    }

    public void PlayGame()//Make the game run until someone is out of cards
    {
        while (!IsDeckEmpty(yourDeck) && !IsDeckEmpty(opponentDeck))
        {
            PlayTurn(yourDeck, opponentDeck);
        }
        if(IsDeckEmpty(yourDeck)) Console.WriteLine("YOU LOST!");
        else if(IsDeckEmpty(opponentDeck)) Console.WriteLine("YOU WON!");
    }
    private void PlayTurn(Deck myDeck, Deck oppDeck)//Plays a turn of the game: ypur top card vs your opponents top card
    {
        Console.WriteLine($"you have {myDeck.Count()}  cards and your opponent have {oppDeck.Count()}");
        Console.WriteLine("Press enter to play a Turn");
        Console.ReadLine();
        Card myCard = myDeck.DrawCard();
        Card oppCard = oppDeck.DrawCard();
        Console.WriteLine("You pulled: ");
        myCard.ShowCard();
        Console.WriteLine("Your opponent pulled: ");
        oppCard.ShowCard();
        Console.WriteLine();
        if (IsCardsEqual(myCard, oppCard))
        {
            Console.WriteLine("it's a draw!");
            myDeck.AddCard(myCard);
            oppDeck.AddCard(oppCard);
        }
        else if (IsCardGreater(myCard, oppCard))
        {
            Console.WriteLine("You won that round!");
            myDeck.ShuffleCardsToDeck(myCard, oppCard);
        }
    
        else
        {
            Console.WriteLine("You lost that round!");
            oppDeck.ShuffleCardsToDeck(myCard, oppCard);
        }
    }

    bool IsCardsEqual(Card c1, Card c2)//Checks if the cards have the same value, true if it is, false if it isn't
    {
        return c1.getValue() == c2.getValue();
    }

    bool IsCardGreater(Card c1, Card c2)//Checks if c1's value is greater that c2's, true if it is, false if it isn't
    {
        return c1.getValue() > c2.getValue();
    }
    bool IsDeckEmpty(Deck deck)//Checks if deck is empty, true if it is, false if it isn't
    {
        if(deck.Count() == 0) return true;
        return false;
    }
}