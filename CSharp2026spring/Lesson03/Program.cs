for (int i = 10; i <= 30; i++)
{
    if (i % 2 == 0)
        {
        Console.Write(i + " ");
        }
}

Console.WriteLine()
    ;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i * i);
}

Console.WriteLine("enter the triangle base");
int tBase = int.Parse(Console.ReadLine());
for (int i = 1; i <= tBase; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

int num1;
do
{
    Console.WriteLine("enter a number");
    num1 = int.Parse(Console.ReadLine());
} while (num1 != -1);
Console.WriteLine("Exit Program");