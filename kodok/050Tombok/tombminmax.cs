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
		int legNagyobb = lottoSzamok.Max();
		int maxHelye = Array.IndexOf(lottoSzamok, legNagyobb);
		int legKisebb = lottoSzamok.Min();	
		int minHelye = Array.IndexOf(lottoSzamok,legKisebb);
		//ki�rat�s:
		Console.WriteLine("Legnagyobb sz�m: "+ legNagyobb);
		Console.WriteLine("Legnagyobb sz�m a "+ maxHelye + " index�");
		Console.WriteLine("Legkisebb sz�m: "+ legKisebb);		
		Console.WriteLine("Legkisebb sz�m a "+ minHelye + " index�");
		}
}