using System;
using System.Linq;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[]{88, 23, 45, 2, 9}; //deklar�l�s �s inicializ�l�s: 5 db eg�sz sz�m
		
		//ki�rat�s:
		Console.WriteLine("A t�mb:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam +", ");
			}
		Console.WriteLine();
		//legnagyobb sz�m:
		int osszeg = lottoSzamok.Sum();
		//ki�rat�s:	
		Console.WriteLine("Lott�sz�mok �sszege: "+ osszeg);		
		}
}