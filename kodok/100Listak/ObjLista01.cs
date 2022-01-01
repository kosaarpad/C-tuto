using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
class Allamferfi
{
	public string Nev;
	public int Kezd, Veg;
	public string Titulus;
	public Allamferfi(string ujNev, int ujKezd, int ujVeg, string ujTitulus)
	{
		this.Nev=ujNev;
		this.Kezd=ujKezd;
		this.Veg=ujVeg;
		this.Titulus=ujTitulus;
	}
	
}
class Program
{
	static List<Allamferfi> vezetok = new List<Allamferfi>();
	

static void Main()
	{
	
	string[] szoveg= File.ReadAllLines("Allamffi.csv");
	foreach (string sor in szoveg)
		{
		Console.WriteLine("a teljes sor:"+sor);
		
		string[] adat=sor.Split(';');
		string nev=adat[0];
		int kezd=Convert.ToInt32(adat[1]);
		int veg=Convert.ToInt32(adat[2]);
		string titulus=adat[3];
		Allamferfi a1=new Allamferfi(nev, kezd, veg, titulus);
		vezetok.Add(a1);
		
		}
	//kiírjuk az adatokat	a listából:
	
	foreach (Allamferfi af in vezetok)
		{
		Console.WriteLine("neve:"+af.Nev);			
		}
	
	Console.ReadKey();	
	}
}