
 

    bool repeat = true;

    while (repeat) {

    Console.Write("Type the 1st number: ");
    decimal value1 = decimal.Parse(Console.ReadLine()!);

    Console.Write("\nType the 2nd number: ");
    decimal value2 = decimal.Parse(Console.ReadLine()!);

        if (value1 >= 0 && value2 >= 0)
    {
        Calculator.Calculate(value1, value2);
        repeat = false;
    }
    else
    {
        Console.WriteLine("Type a valid number!");
        Console.ReadKey();
        Console.Clear();
    }

    }


class Calculator
{
    decimal value1;
    decimal value2;

    static decimal result;

    public static void Calculate (decimal value1, decimal value2)
    {
        result = value1 + value2;

        Console.WriteLine(result);
        Console.ReadKey();
    }
}