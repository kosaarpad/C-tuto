using System;
class Program
	{
    static void Main()
		{
		bool A = false, B=false, C;
		C = A && B;
		Console.WriteLine("Ha A=" + A + ", B = " + B + " akkor A && B = " + C);
		A = false; B = true;
		C = A && B;
		Console.WriteLine("Ha A=" + A + ", B = " + B + " akkor A && B = " + C);
		A = true; B = false;
		C = A && B;
		Console.WriteLine("Ha A=" + A + ", B = " + B + " akkor A && B = " + C);
		A = true; B = true;
		C = A && B;
		Console.WriteLine("Ha A=" + A + ", B = " + B + " akkor A && B = " + C);
		}
	}