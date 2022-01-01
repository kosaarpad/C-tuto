using System;
using System.Collections.Generic;
using System.Linq;
public  class Diak
    { 
	public string Nev;
    public int Szulev;
    public double Atlag;
    public Diak (string ujNev, int ujSzulev, double ujAtlag)
		{
		 this.Nev=ujNev;
		 this.Szulev=ujSzulev;
		 this.Atlag=ujAtlag;
		}
	}
public class Program
	{
	static List<Diak> csoport = new List<Diak>();
    static void Feltolt()
		{
		csoport.Add(new Diak("Pista", 2001, 3.14));
		csoport.Add(new Diak("Kata", 2000, 2.74));
		csoport.Add(new Diak("Bela", 2002, 4.72));
		csoport.Add(new Diak("Anna", 1997, 4.86));
		csoport.Add(new Diak("Vazul", 2003, 1.82));
		csoport.Add(new Diak("Vivien", 1998, 2.91));			
		}
	static void Felsorol()
		{
		foreach(Diak d in csoport)
			{
			Console.WriteLine(d.Nev+", "+d.Szulev+", "+d.Atlag);
			}
		}
	public static void Main()
		{
		Feltolt();	
		Felsorol();
		//Rendezés név szerint:
		csoport.Sort((x, y) => x.Nev.CompareTo(y.Nev));
		Console.WriteLine("Rendezve Név szerint:");
		Felsorol();
		//Rendezés születési év szerint:
		csoport.Sort((x, y) => x.Szulev.CompareTo(y.Szulev));
		Console.WriteLine("Rendezve születési év szerint:");
		Felsorol();
		//Rendezés átlag szerint:
		csoport.Sort((x, y) => x.Atlag.CompareTo(y.Atlag));
		Console.WriteLine("Rendezve átlag szerint:");
		Felsorol();
		Console.WriteLine("Rendezve átlag szerint csökkenő sorrendben:");
		csoport.Sort((y, x) => x.Atlag.CompareTo(y.Atlag));
		Felsorol();
		Console.WriteLine("A legjobb tanuló:");
		Console.WriteLine(csoport[0].Nev);
		Console.WriteLine(csoport[0].Szulev);
		Console.WriteLine(csoport[0].atlag);
		int utolso=csoport.Count-1;
		Console.WriteLine("A leggyengébb tanuló:");
		Console.WriteLine(csoport[utolso].Nev);
		Console.WriteLine(csoport[utolso].Szulev);
		Console.WriteLine(csoport[utolso].atlag);
		
		}
	}	