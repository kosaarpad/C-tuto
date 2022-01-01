using System;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[]{88, 23, 45, 2, 9}; //deklarálás és inicializálás: 5 db egész szám
		
		//kiíratás:
		Console.WriteLine("A tömb rendezés elõtt:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam +", ");
			}
		Console.WriteLine();
		//rendezzük:
		Array.Sort(lottoSzamok);
		//kiíratás:
		
		Console.WriteLine("A tömb rendezés után:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam + ", ");
			}
		Console.WriteLine();	
		//csökkenõ sorrendben
		Array.Reverse(lottoSzamok);
		//kiíratás:
		Console.WriteLine("A tömb csökkenõ sorrendben:");
		foreach ( int szam in lottoSzamok)
			{
			Console.Write(szam + ", ");
			}
		
		}
}