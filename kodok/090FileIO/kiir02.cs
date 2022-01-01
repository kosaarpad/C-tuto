using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
	string[] sorok = new string[48];
	string[] csnevek=new string[]{"Kiss","Nagy","Szabó","Kovács","Fehér", "Fekete"};
	string[] fiunevek=new string[]{"Ádám", "Béla", "Ferenc", "Dániel"};
	string[] lanynevek=new string[]{"Adél", "Blanka", "Fanni", "Diána"};
	
	Random r = new Random();
	int sorszam=0;
	foreach(string csnev in csnevek)
		{
		foreach(string fnev in fiunevek)
			{
			string nev=csnev+" "+fnev;
			int szul_ev=r.Next(1998, 2010);
            sorok[sorszam]=nev+";F;"+szul_ev;
			sorszam++;
			}		
		}
	foreach(string csnev in csnevek)
		{
		foreach(string lnev in lanynevek)
			{
			string nev=csnev+" "+lnev;
			int szul_ev=r.Next(1998, 2010);
            sorok[sorszam]=nev+";L;"+szul_ev;
			sorszam++;
			}		
		}
		
	File.WriteAllLines("adatok.csv", sorok, Encoding.UTF8);
	Console.WriteLine("fájl sikeresen létrehozva.");
	Console.ReadKey();	
	}
}
