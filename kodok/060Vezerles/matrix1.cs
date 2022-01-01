using System;

class Program
{
	static void Main()
		{

		int [,] m = {
									{0, 1, 2, 3} , /* a 0. indexű sor értékei */
									{4, 5, 6, 7} , /* az 1. indexű sor értékei */
									{8, 9, 10, 11} /* a 2. indexű sor értékei */
								};
		int sor, oszlop;
		for(sor = 0;sor < 3; sor++)
				for(oszlop = 0;oszlop < 4; oszlop++)
					{
					Console.WriteLine("m["+sor+","+oszlop+"]="+m[sor, oszlop]); 
					}
		}

	
}