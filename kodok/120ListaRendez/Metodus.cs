using System;
class Kutya
{
string Nev;
int Szul_ev;
string Fajta;
//Konstruktor
void Kutya(string ujNev, int ujSzul_ev, string ujFajta)
	{
	this.nev=ujNev;
	this.Szul_ev=ujSzul_ev;
	this.Fajta=ujFajta;
	}
//metódus:
void Ugat()
	{
	Console.WriteLine("Vau!");
	}
//másik metódus:
void Bemutatkozik()
	{
	Console.WriteLine("Vau!");
	Console.WriteLine(this.Nev+" vagyok.");
	}
	
}
class Program
{
    static void Main()
    {
	Kutya k1 = new Kutya("Bodri", 2010, "fox-terrier");
	k1.Ugat();
	k1.Bemutatkozik();
	}
}