using System;

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
		int legNagyobb = lottoSzamok[0];
		int maxHelye = 0;
		int tombMeret = lottoSzamok.Length;
		for( int i=1;i < tombMeret; i++)
			{
			if (lottoSzamok[i] > legNagyobb)
				{
				maxHelye = i;
				legNagyobb = lottoSzamok[i];
				}
			}			
		//kiíratás:
		Console.WriteLine("Legnagyobb szám: "+ legNagyobb);
		Console.WriteLine("Legnagyobb szám a "+ maxHelye + " indexû");
		}
}