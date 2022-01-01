using System;
using System.Text;

public class Test
{
    static void Main()
    {
      //char kar='*';
			 Console.OutputEncoding = System.Text.Encoding.UTF8;
			int sor, oszlop=1;
			Console.Clear();
			int n =32;
			for (oszlop=0;oszlop<4;oszlop++)
				{
				for (sor=0;sor<4;sor++)
					{
					//Console.SetCursorPosition(oszlop, sor);
					Console.WriteLine(""+ n+" "+ '\u0341');
					n++;
					}
				}
		Console.ReadLine();		
		Console.OutputEncoding = System.Text.Encoding.ASCII;
    }
}