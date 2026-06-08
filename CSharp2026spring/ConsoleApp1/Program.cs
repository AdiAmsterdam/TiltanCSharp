float basis = int.Parse(Console.ReadLine());
float hezka = int.Parse(Console.ReadLine());
float sum = 1;
if (hezka > 0)
{
    for (int i = 1; i <= hezka; i++)
    {
        sum *= basis;
    }
    Console.WriteLine(sum);
}



if (hezka < 0)
{
    for (int i = -1-3; i >= hezka; i--)
    {
        sum *= basis;
    }

    Console.WriteLine(1/sum);
}