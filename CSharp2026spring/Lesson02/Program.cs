Console.WriteLine("write a number:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("what operation do yo want to do? (+,-,/,%,*)");
char operation = char.Parse(Console.ReadLine());
Console.WriteLine("write another number:");
double num2 = double.Parse(Console.ReadLine());

/*if (operation == '+')
{
    Console.WriteLine(num1 + num2);
}
else if (operation == '-')
{
    Console.WriteLine(num1 - num2);
}
else if (operation == '*')
{
    Console.WriteLine(num1 * num2);
}
else if (operation == '/')
{
    Console.WriteLine(num1 / num2);
}
else if (operation == '%')
{
    Console.WriteLine(num1 % num2);
}
else
{
    Console.WriteLine("invalid operation");
}*/

switch (operation) // דרך יעילה מאוד לבדוק שיוויון על משתנה אחד
{
    case '+':
        Console.WriteLine(num1 + num2);
        break;
    case  '-':
        Console.WriteLine(num1 - num2);
        break;
    case '*':
        Console.WriteLine(num1 * num2);
        break;
    case  '/':
        Console.WriteLine(num1 / num2);
        break;
    case  '%':
        Console.WriteLine(num1 % num2);
        break;
    default:
        Console.WriteLine("operation is invalid");
        break;
}


