using System;
using System.Collections.Generic;
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
		//lista elemszámainak kiíratása:
		Console.WriteLine("Ennyi elem van a listában: "+szamok.Count);
		//elem törlése a listából. Töröljük a 13-as értéket:
		//ha több 13-as érték lenne, akkor a legkisebb sorszámút törli
		szamok.Remove(13);
		ListatKiir();
		//a 17-es értékű elem beszúrása 2. sorszámú helyre:
		szamok.Insert(2, 17);
		ListatKiir();
		//Elem törlése a 2. indexű helyről: törli a 17-et:
		szamok.RemoveAt(2);
		ListatKiir();
		}
}
