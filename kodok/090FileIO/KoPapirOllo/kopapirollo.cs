using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Text;
class Jatszma
{
	public char Feri, //feri dobása 
	           Geza; //géza dobása
	//konstruktor
	public Jatszma(char ujF, char ujG)
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
	foreach (string sor in File.ReadLines("jatszmak.csv", Encoding.UTF8))
		{
		//Console.WriteLine("a teljes sor:"+sor);
		string[] szamok=sor.Split(';');//elválasztójel a pontosvessző
		char c1=Convert.ToChar(szamok[0]); //első szövegből karakter
		char c2=Convert.ToChar(szamok[1]); //a 2. szövegből karakter
		Jatszma j1=new Jatszma(c1, c2);
		jatszmak.Add(j1);
		}	
	}
	static void Kiir()
	{
		foreach (Jatszma j in jatszmak)
		{
			Console.WriteLine("Feri tippje:"+j.Feri+" Géza tippje: "+j.Geza );
		}
	}
static void Kiment()
{
	int N=jatszmak.Count;
	string[] sorok = new string[N];
	string eredm;
	string tippszoveg;
	int i=0; //a sorok tömb indexe
	foreach (Jatszma j1 in jatszmak)
		{
			//megállapítjuk a két gurítás alapján a végeredményt:
			/*egy szöveg tárolja a lehetséges játszmákat: 
			 "KK", "KO", "KP","OK", "OO", "OP"...stb
			 Az első karakter a feri tippje, a 2. a Gézáé
			 */
			tippszoveg=""+j1.Feri+j1.Geza; 
			if (tippszoveg=="PK" || tippszoveg=="OP"|| tippszoveg=="KO")
				{
					eredm= "Feri nyert";
				}
			else if (tippszoveg=="KP" || tippszoveg=="PO"|| tippszoveg=="OK")
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