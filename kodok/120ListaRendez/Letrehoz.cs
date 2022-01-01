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
	
}
class Program
{
    static void Main()
    {
	Kutya k1 = new Kutya("Bodri", 2010, "fox-terrier");
	Kutya k2 = new Kutya("Gubanc", 2015, "puli");
	Kutya k2 = new Kutya("Rozsda", 2015, "tacskó");
	Console.WriteLine("k1 kutya neve: ", k1.Nev);
	Console.WriteLine("k2 kutya születési éve: ", k2.Szul_ev);
	}
}