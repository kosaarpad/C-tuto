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
		
		double max = szamok[0];//feltételezzük, h. a lista elsõ eleme a legnagyobb
		foreach(double sz in szamok)
			{
			if (sz>max)
				{
				max = sz;
				}
			}
			
		Console.WriteLine("A legnagyobb érték:"+max);		
		//ugyanez az összegzés  Linq-val:
		double max2 = szamok.Max();
		Console.WriteLine("A legnagyobb érték:"+ max2);
		}
	}		