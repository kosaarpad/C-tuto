using System;

class Program
{
	static void Main()
		{
		int[] lottoSzamok = new int[5]; //deklarálás és inicializálás: 5 db egész szám
		for ( int n=0; n < 5; n++)
			{
			lottoSzamok[n] = n*10+5;
			}
		//kiíratás:
		for ( int n=0; n < 5; n++)
			{
			Console.WriteLine("Az "+ n +". szám: "+lottoSzamok[n]);
			}
		
		}
}