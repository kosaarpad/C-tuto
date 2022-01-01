using System;

class Program
{
    static void Main(string[] args)
    {
	string ertek;
	double x, ujx=0, szam, gyok=0, akthiba, hiba;
    int n=1;
	Console.WriteLine("Ez a program kiszámítja egy adott szám négyzetgyökét.");
	Console.WriteLine("Kérem a számot:");
	ertek = Console.ReadLine();
	szam = Convert.ToDouble(ertek);
	akthiba=1;
	x=szam/2;
	hiba=1e-20;
	while (akthiba>hiba)
	    {
		 ujx= 0.5*(x + szam / x);
		 if (ujx>x) akthiba=ujx-x;
		 else akthiba=x-ujx;
		 x = ujx;
		 Console.WriteLine("n= " + n + " x = " + x);
		 n++;
		}
	gyok=ujx;
	Console.WriteLine("Az " + szam +" négyzetgyöke = " +gyok);
	//Console.WriteLine("Az igazi sin(" + fok +") = " + Math.Sin(x));
	}
}