using System;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[]{88, 23, 45, 2, 9}; //deklar�l�s �s inicializ�l�s: 5 db eg�sz sz�m
		
		//ki�rat�s:
		Console.WriteLine("A t�mb rendez�s el�tt:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam +", ");
			}
		Console.WriteLine();
		//rendezz�k:
		Array.Sort(lottoSzamok);
		//ki�rat�s:
		
		Console.WriteLine("A t�mb rendez�s ut�n:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam + ", ");
			}
		Console.WriteLine();	
		//cs�kken� sorrendben
		Array.Reverse(lottoSzamok);
		//ki�rat�s:
		Console.WriteLine("A t�mb cs�kken� sorrendben:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam + ", ");
			}
		
		}
}