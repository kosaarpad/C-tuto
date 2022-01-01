using System;

class Program
{
    static void Main()
    {
 
        double a = 2;
		int b = 3;
        double pi = Math.PI;
		Console.WriteLine("gyökvonás: gyök 2 = "+Math.Sqrt(a));
		Console.WriteLine("hatványozás: 2 a 3-on = "+Math.Pow(a,b));
		Console.WriteLine("köbgyökvonás: köbgyök 2 = "+Math.Pow(a, 1.0/3));
		Console.WriteLine("köbgyökvonás: köbgyök 2 = "+Math.Cbrt(-a));
		Console.WriteLine("Ln 2 = "+Math.Log(2));
		Console.WriteLine("Log2 8 = "+Math.Log(8, 2));
		Console.WriteLine("Lg 2  = "+Math.Log10(2));
		Console.WriteLine("kerekítés egészre pi = "+Math.Round(pi));
		Console.WriteLine("kerekítés 4 tizedesjegyre: pi = "+Math.Round(pi,4));
		Console.WriteLine("szinusz(60°) = "+Math.Sin(60*pi/180));
		Console.WriteLine("koszinusz(60°) = "+Math.Cos(60*pi/180));
		
    }
}