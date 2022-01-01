using System;
using System.Collections.Generic;
using System.Linq;
public class Program
	{
	//ha a Program osztályba hozzuk létre a listát, akkor az static kell legyen
	//mert a Program osztály statikus osztály, és a statikus osztály minden tulajdonsága, metódusa statikus kell legyen
	static List<int> szamok = new List<int>();
	static void ListatKiir()
	{//lista bejárása, kiíratása a konzolra:
		foreach (int elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();	
	}
	public static void Main()
		{
		//elemek hozzáadása a listához:
		szamok.Add(10);
		szamok.Add(10);//lehet 2 egyforma érték is...
		szamok.Add(13);
		szamok.Add(20);
		szamok.Add(30);
		szamok.Add(10);
		szamok.Add(50);
		ListatKiir();
		//elemek megszámlálása: hány darab 10-es értékem van?
		int tizesDB = 0;
		foreach(int elem in szamok)
			{
				tizesDB++;
			}
		Console.WriteLine("a 10-es értékek száma:"+ tizesDB);
		int DB = szamok.Count(x => x==10);
		Console.WriteLine("a 25-nél kisebb értékek száma:"+ DB);
		}
}
