using System;

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
		//ki�rat�s:
		Console.WriteLine("Legnagyobb sz�m: "+ legNagyobb);
		Console.WriteLine("Legnagyobb sz�m a "+ maxHelye + " index�");
		}
}