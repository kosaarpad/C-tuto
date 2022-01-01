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
		csoport.Add(new Diak("Kata", 2000, 4.94));
		csoport.Add(new Diak("Bela", 2002, 4.72));
		csoport.Add(new Diak("Anna", 1997, 3.86));
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
		//Legjobb átlag:
		double maxAtlag = csoport.Max(x=>x.Atlag);
		
		Console.WriteLine("legjobb átlag:");
		Console.WriteLine(maxAtlag);
		//legjobb átlagú diák keresése: Find metódus
		Diak d1 = csoport.Find(x => x.Atlag == maxAtlag);
		Console.WriteLine("legjobb átlagú diák:");
		Console.WriteLine(d1.Nev+", "+d1.Szulev+", "+d1.Atlag);
		//legidősebb diák az, aki a legkorábban született:
		int minSzulev = csoport.Min(x=>x.Szulev);
		//A legidősebb diák:
		Diak d2 = csoport.Find(x => x.Szulev == minSzulev);
		Console.WriteLine("legidősebb diák:");
		Console.WriteLine(d2.Nev+", "+d2.Szulev+", "+d2.Atlag);
		//létezik-e Pista nevű diák?
		Console.WriteLine(csoport.Exists(x => x.Nev =="Pista"));
		
		}
	}	