using System;
class Program
	{
    static void Main()
		{
		string sz = "abrakadabra";
		string sz2 = sz.Replace('a','e');
		string sz3 = sz.Replace("bra","***");
		Console.WriteLine("sz2 = "+sz2);
		Console.WriteLine("sz3 = "+sz3);
		Console.ReadKey();
		}
	}