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
		int osszeg = lottoSzamok.Sum();
		//kiíratás:	
		Console.WriteLine("Lottószámok összege: "+ osszeg);		
		}
}