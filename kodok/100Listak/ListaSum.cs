using System;
using System.Collections.Generic;
using System.Linq;
public class Program
	{
	static List <double>szamok = new List<double>();
	
	public static void Main()
		{
		//elemek hozz�ad�sa a list�hoz:
		szamok.Add(2.3);
		szamok.Add(1.7);
		szamok.Add(3.5);
		szamok.Add(2.5);
		
		double osszeg = 0;//az �sszegv�ltoz�t l�trehoz�skor lenull�zzuk
		foreach(double sz in szamok)
			{
			osszeg += sz;
			}
		Console.WriteLine("A sz�mok �sszege:"+osszeg);		
		//ugyanez az �sszegz�s  Linq-val:
		double osszeg2 = szamok.Sum();
		Console.WriteLine("a sz�mok �sszege:"+ osszeg2);
		}
	}		