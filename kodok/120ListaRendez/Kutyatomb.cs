using System;
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
	static Kutya[] kutyak = new Kutya[5];//Kutya típusú változók	
    static void Main()
		{
			
		kutyak[0] = new Kutya("Bodri", 3);//
		kutyak[1] = new Kutya("Füles", 5);//
		kutyak[2] = new Kutya("Borzas", 1);//
		kutyak[3] = new Kutya("Tücsök", 2);//
		kutyak[4] = new Kutya("Bogáncs", 7);//
		for (int i=0; i<5; i++)
			{
			kutyak[i].Bemutatkozik();
			kutyak[i].Ugat(i+1);
			}
		//ugyanez foreach ciklussal: 
		int j=0;
        foreach ( Kutya kutyapeldany in kutyak)
			{
			kutyapeldany.Bemutatkozik();
			kutyapeldany.Ugat(j+1);
			j++;
			}		
		}
	}