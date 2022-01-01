using System;
using System.Collections.Generic;
using System.Linq;
public class Program
	{
	static List <double>szamok = new List<double>();
	
	public static void Main()
		{
		//elemek hozzáadása a listához:
		szamok.Add(2.3);
		szamok.Add(1.7);
		szamok.Add(3.5);
		szamok.Add(2.5);
		
		double osszeg = 0;//az összegváltozót létrehozáskor lenullázzuk
		foreach(double sz in szamok)
			{
			osszeg += sz;
			}
		Console.WriteLine("A számok összege:"+osszeg);		
		//ugyanez az összegzés  Linq-val:
		double osszeg2 = szamok.Sum();
		Console.WriteLine("a számok összege:"+ osszeg2);
		}
	}		