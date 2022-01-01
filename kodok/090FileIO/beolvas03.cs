using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
	int szamlalo=0;
	foreach (string sor in File.ReadLines("adat.csv", Encoding.UTF8))
		{
		Console.WriteLine("a teljes sor:"+sor);
		string[] szavak=sor.Split(';');
		Console.WriteLine("az első adat:"+szavak[0]);
		Console.WriteLine("a második adat:"+szavak[1]);
		Console.WriteLine("a harmadik adat:"+szavak[2]);
		if (szamlalo>0)
			{
			int szul_ev=Convert.ToInt32(szavak[1]); //"1998" --> 1998
			int kor = 2021-szul_ev;
			Console.WriteLine(szavak[0]+" életkora: "+kor+" év.");
			}
		szamlalo++;
		}
	Console.ReadKey();	
	}
}