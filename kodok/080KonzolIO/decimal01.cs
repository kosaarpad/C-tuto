using System;

public class Test
{
    static void Main()
    {
        decimal d = 0.00000000000010000m;
        while (d != 0m)
        {
            Console.WriteLine (d);
            d = d/5m;
        }
    }
}