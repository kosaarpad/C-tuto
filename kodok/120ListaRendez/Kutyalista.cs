using System;
using System.Collections.Generic;//listák, halmazok, szótárak kezeléséhez

class Kutya
{
public string nev;
public int eletkor;
public Kutya(string ujnev, int ujeletkor )//Konstruktor	
	{
	this.nev = ujnev;
	this.eletkor = ujeletkor;
	}
public void Bemutatkozik()
	{
	Console.WriteLine("A nevem " + this.nev + " és " + this.eletkor + " éves vagyok.");
	}
public void Ugat(int hanyszor)
	{int i;
	for(i=0;i<hanyszor;i++)
		{
		Console.Write("Vau!!!");
		}
	Console.WriteLine();	
	}

}
class Program
	{	
	//létrehozunk egy kutyak nevű, üres listát
	static List <Kutya> kutyak = new List<Kutya>();
    static void Main()
		{
		//lista feltöltése:	
		kutyak.Add(new Kutya("Bodri", 3));//
		kutyak.Add(new Kutya("Füles", 5));//
		kutyak.Add(new Kutya("Borzas", 1));//
		kutyak.Add(new Kutya("Tücsök", 2));//
		kutyak.Add(new Kutya("Bogáncs", 7));//
		/*
		listafeltöltés kicsit másképp:
		Kutya k;   
		k = new Kutya("Bodri", 3) 
		kutyak.Add(k);
		*/
		int j=0;
        foreach ( Kutya kutyapeldany in kutyak)
			{
			kutyapeldany.Bemutatkozik();
			kutyapeldany.Ugat(j+1);
			j++;
			}		
		}
	}