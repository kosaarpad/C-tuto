using System;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[5]; //deklar�l�s �s inicializ�l�s: 5 db eg�sz sz�m
		for ( int n=0; n < 5; n++)
			{
			lottoSzamok[n] = n*10+5;
			}
		//ki�rat�s:
		for ( int n=0; n < 5; n++)
			{
			Console.WriteLine("Az "+ n +". sz�m: "+lottoSzamok[n]);
			}
		
		}
}