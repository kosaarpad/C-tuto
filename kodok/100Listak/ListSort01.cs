using System;
using System.Collections.Generic;

public class Program
	{
	static List <double>szamok = new List<double>();
	static void ListatKiir()
	{//lista bejárása, kiíratása a konzolra:
		foreach (double elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();	
	}
	public static void Main()
		{
		//elemek hozzáadása a listához:
		szamok.Add(2.3);
		szamok.Add(1.7);
		szamok.Add(3.5);
		szamok.Add(2.5);
		Console.WriteLine("A lista rendezés elõtt:");
		ListatKiir();		
		szamok.Sort();
		Console.WriteLine("A lista rendezés után:");
		ListatKiir();		
		}
	}		