using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        //string utvonal = @"c:\temp\MyTest.txt";

        // 
        string [] pluszSorok = new string[3];
        pluszSorok[0]= "Ez egy sor" + Environment.NewLine;
        pluszSorok[1]= "Ez meg még egy sor..." + Environment.NewLine;
        pluszSorok[2]= "Ez meg a ráadás sor..." + Environment.NewLine;
        string utvonal="kimenet1.txt";
        if (File.Exists(utvonal))
			{
			foreach (string sor in pluszSorok)  
					File.AppendAllText(utvonal, sor, Encoding.UTF8);
			Console.WriteLine("fájl kiegészítve");		
			}

        
    }
}