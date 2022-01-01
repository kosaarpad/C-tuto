using System;
using System.Linq;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[]{88, 23, 45, 2, 9}; //deklarálás és inicializálás: 5 db egész szám
		
		//kiíratás:
		Console.WriteLine("A tömb:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam +", ");
			}
		Console.WriteLine();
		//legnagyobb szám:
		int legNagyobb = lottoSzamok.Max();
		int maxHelye = Array.IndexOf(lottoSzamok, legNagyobb);
		int legKisebb = lottoSzamok.Min();	
		int minHelye = Array.IndexOf(lottoSzamok,legKisebb);
		//kiíratás:
		Console.WriteLine("Legnagyobb szám: "+ legNagyobb);
		Console.WriteLine("Legnagyobb szám a "+ maxHelye + " indexû");
		Console.WriteLine("Legkisebb szám: "+ legKisebb);		
		Console.WriteLine("Legkisebb szám a "+ minHelye + " indexû");
		}
}