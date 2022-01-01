using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
class Jegy
{
public int Sorszam;	
public string Nev;	
public char Neme;
public string Datum;
public string Tantargy;
public int Hanyas;
public Jegy(int ujSorszam, string ujNev, char ujNeme, string ujDatum, string ujTantargy, int ujHanyas)
	{
	this.Sorszam=ujSorszam;
	this.Nev=ujNev;
	this.Neme=ujNeme;
	this.Datum=ujDatum;
	this.Tantargy=ujTantargy;
	this.Hanyas=ujHanyas;
	}	
}
class Program
{
static List<Jegy> naplo = new List<Jegy>();	
static void Main()
	{
	
	string[] szoveg = File.ReadAllLines("naplo.csv");
    foreach(string sor in szoveg)
		{
		//Console.WriteLine(sor);	
		string[] adat=sor.Split(';');
		int sorsz=Convert.ToInt32(adat[0]);
		string nev=adat[1];
		char neme=Convert.ToChar(adat[2]);
    string datum=adat[3];
    string tantargy=adat[4];
		int hanyas=Convert.ToInt32(adat[5]);
		Jegy j=new Jegy(sorsz, nev, neme, datum, tantargy, hanyas);
    naplo.Add(j);		
		}
		Kiir();
	}
	public static void Kiir()
	{
	foreach(Jegy j1 in naplo)
		{
		Console.WriteLine("sorsz: "+j1.Sorszam+" Név: "+j1.Nev);
		Console.WriteLine("Dátum:"+j1.Datum+" "+j1.Tantargy+" Osztályzat: "+j1.Hanyas);
		}	
	}
}