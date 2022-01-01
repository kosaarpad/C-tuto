using System;
using System.Collections.Generic;
using System.Linq;
public class Program
	{
	static List <int>szamlista = new List<int>();
	static void ListatKiir()
	{//lista bejárása, kiíratása a konzolra:
		foreach (int elem in szamlista)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();	
	}
	public static void Main()
		{
		int[] szamtomb = new int[3];
		szamtomb[0] = 13;
		szamtomb[1] = 23;
		szamtomb[2] = 33;
		szamlista=szamtomb.ToList();//számtömböt listává alakítjuk, a tömb értékei a szamlista-ba töltõdnek
		ListatKiir();		
		}
	}		