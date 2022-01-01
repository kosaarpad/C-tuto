using System;
class Program
{
	static void Main()
		{

		string [,] orarend = {
									{"sorsz", "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek"} , /* a 0. indexű sor: a napok  */
									{"1.", "Angol","Matek" ,"Fizika" ,"Info", "Rajz" } , /* az 1.sorban az 1. órák */
									{"2.", "Matek" ,"Angol","Kémia" ,"Info", "Földrajz"}, /* a 2. sorban a 2. órák */
									{"3.", "Töri" ,"Fizika","Kémia" ,"Nyelvtan", "Tesi"}, /* ...stb*/
									{"4.", "Info" ,"Biológia","Német" ,"Irodalom", "Tesi"}, /* ...stb*/
									{"5.", "Info" ,"Kémia","Angol" ,"Irodalom", "Osztfőn"} /* ...stb*/
								};
		int sor, oszlop;
		Console.WriteLine();
		for(sor = 0;sor < 5; sor++)
			{
			for(oszlop = 0;oszlop < 6; oszlop++)
				{
				Console.SetCursorPosition(5+oszlop*10, sor*2);
				Console.Write(orarend[sor, oszlop]+", "); 
				}
			Console.WriteLine();	
			}
		}

	
}