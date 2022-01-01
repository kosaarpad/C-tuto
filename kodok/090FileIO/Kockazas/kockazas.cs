using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Text;
class Jatszma
{
	public int Feri, //feri dobása 
	    Geza; //géza dobása
	//konstruktor
	public Jatszma(int ujF, int ujG)
	{
		this.Feri=ujF;
		this.Geza=ujG;
	}
	
}
class Program
{
	static List<Jatszma> jatszmak = new List<Jatszma>();
	static void Beolvas()
	{
	foreach (string sor in File.ReadLines("dobasok.dat", Encoding.UTF8))
		{
		//Console.WriteLine("a teljes sor:"+sor);
		string[] szamok=sor.Split(' ');//elválasztójel a szóköz
		int sz1=Convert.ToInt32(szamok[0]); //első szövegből szám
		int sz2=Convert.ToInt32(szamok[1]); //a 2. szövegből is szám
		Jatszma j1=new Jatszma(sz1, sz2);
		jatszmak.Add(j1);
		}	
	}
	static void Kiir()
	{
		foreach (Jatszma j in jatszmak)
		{
			Console.WriteLine("Feri dobott:"+j.Feri+" Géza dobott: "+j.Geza );
		}
	}
static void Kiment()
{
	int N=jatszmak.Count;
	string[] sorok = new string[N];
	string eredm;
	int i=0; //a sorok tömb indexe
	foreach (Jatszma j1 in jatszmak)
		{
			//megállapítjuk a két gurítás alapján a végeredményt:
			if (j1.Feri>j1.Geza)
				{
					eredm= "Feri nyert";
				}
			else if (j1.Feri<j1.Geza)
				{
					eredm= "Géza nyert";
				}
			else
				{
					eredm= "döntetlen";
				}
			//elkészítjük az eredmeny.txt fájl egy sorát szám-szóköz-szám-szóköz-eredményszöveg:	
			sorok[i]=""+j1.Feri+" "+j1.Geza+" "+eredm;
			i++;//lépünk a sorok tömb köv. pozíciójára
		}
		
	File.WriteAllLines("eredmeny.txt", sorok, Encoding.UTF8);
	Console.WriteLine("eredmeny.txt fájl sikeresen létrehozva.");
}
static void Main()
	{
	Beolvas();
	Kiir();
	Kiment();
	Console.ReadKey();	
	}
}