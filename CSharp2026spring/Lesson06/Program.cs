Console.WriteLine("Write your message:");
string message = Console.ReadLine();
if (IsLower(message))
{
    if (message.Contains("gameofthrone"))
    {
        Console.WriteLine("cheat code detected");
    }
    else Console.WriteLine("No cheat code detected");
}
else Console.WriteLine("your message is invalid!");

PrintBackwards(message);


bool IsLower(string message)
{
    char[] charArray = message.ToCharArray();
    foreach (char c in charArray)
    {
        if (!CheckIfBetween(c)) return false;
    }
    return true;
}

void PrintBackwards(string message)
{
    char[] charArray = message.ToCharArray();
    int arrayLength = charArray.Length ;
    for (int i = arrayLength - 1; i >= 0; i--)
    {
        Console.Write(charArray[i]);
    }
}

bool CheckIfBetween(char c1)
{
    if (c1 < 'a' || c1 > 'z')
    {
        return false;
    }

    return true;
}