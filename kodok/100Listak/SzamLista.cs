using System;
using System.Collections.Generic;
public class Program
	{


	public static void Main()
		{
		List<int> szamok = new List<int>();//itt a lista még üres...
		//elemek hozzáadása a listához:
		szamok.Add(10);
		szamok.Add(10);//lehet 2 egyforma érték is...
		szamok.Add(13);
		szamok.Add(20);
		szamok.Add(30);
		szamok.Add(10);
		szamok.Add(50);
		//lista bejárása, kiíratása a konzolra:
		foreach (int elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		//lista elemszámainak kiíratása:
		Console.WriteLine();
		Console.WriteLine("Ennyi elem van a listában: "+szamok.Count);
		//elem törlése a listából. Töröljük a 13-as értéket:
		//ha több 13-as érték lenne, akkor a legkisebb sorszámút törli
		szamok.Remove(13);
		foreach (int elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();	
		//a 17-es értékű elem beszúrása 2. sorszámú helyre:
		szamok.Insert(2, 17);
		foreach (int elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();
		//Elem törlése a 2. indexű helyről: törli a 17-et:
		szamok.RemoveAt(2);
		foreach (int elem in szamok)
			{
			Console.Write(elem + ", ");
			}
		Console.WriteLine();
		}
}
