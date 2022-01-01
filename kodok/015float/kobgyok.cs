using System;

class Program
{
  static void Main(string[] args)
    {
		string ertek;
		double x;
		ertek = Console.ReadLine();
		x = Convert.ToDouble(ertek);	
		Console.WriteLine("Az x: " + x);
		Console.WriteLine("Az x köbgyöke: " + Math.Cbrt(x));
		Console.ReadKey();
		}
}