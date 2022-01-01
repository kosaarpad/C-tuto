using System;
using System.Collections.Generic;
using System.Linq;
public class Program
	{
	//ha a Program osztályba hozzuk létre a listát, akkor az static kell legyen
	//mert a Program osztály statikus osztály, és a statikus osztály minden tulajdonsága, metódusa statikus kell legyen
	static List<string> nevsor = new List<string>();
	static void ListatKiir()
	{//lista bejárása, kiíratása a konzolra:
		foreach (string elem in nevsor)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();	
	}
	public static void Main()
		{
		//elemek hozzáadása a listához:
		nevsor.Add("Kata");
		nevsor.Add("Kata");//lehet 2 egyforma érték is...
		nevsor.Add("Feri");
		nevsor.Add("Béla");
		nevsor.Add("Sári");
		nevsor.Add("Zsuzsi");
		nevsor.Add("Peti");
		ListatKiir();
		//lista elemszámainak kiíratása:
		Console.WriteLine("Ennyi elem van a listában: "+nevsor.Count);
		//elem törlése a listából. Töröljük a "Béla" értéket:
		//ha több "Béla" érték lenne, akkor a legkisebb sorszámút törli
		nevsor.Remove("Béla");
		ListatKiir();
		//a "Quasimodo" értékű elem beszúrása 2. sorszámú helyre:
		nevsor.Insert(2, "Quasimodo");
		ListatKiir();
		//Elem törlése a 2. indexű helyről: törli a "Quasimodo"-t:
		nevsor.RemoveAt(2);
		ListatKiir();
		int DB = nevsor.Count(x => x.Equals("Kata"));
		Console.WriteLine("a Katák száma:"+ DB);
		}
}
