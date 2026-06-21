namespace CreateCharacter;
public struct Character
{
    public string name;
    public Characterclass Class;
    public int level;
    public int health;

    public void PrintStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("class: " + Class);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("Health: " + health);
    }
}