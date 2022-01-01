using System;

class Program
{
    static void Main(string[] args)
    {
	string ertek;
	double fok, x, x2, tag, koszin, akthiba, hiba;
	int n;
	Console.WriteLine("Ez a program kiszámítja egy adott szög(0..90°) koszinuszát.");
	Console.WriteLine("Hány fokos a szög? (0..90)");
	ertek = Console.ReadLine();
	
	fok = Convert.ToDouble(ertek);
	x=fok*3.14159265358979323846/180;
	//x=fok*Math.PI/180;
	akthiba=1;
	koszin=1;
	tag=1;
	hiba=1e-20;
	//elojel=1;//ezzel az előjel változóval a program kerekítési hibákat ad.
	n=2;
	x2=x*x;
	while (akthiba>hiba)
	    {
		 //elojel=-elojel;
		 tag = -tag*x2/((n-1)*n); 
		 koszin = koszin + tag;
		 if (tag<0) akthiba=-tag;
		 else akthiba=tag;
		 Console.WriteLine("n = "+n+"  akthiba = " + akthiba);
		 n+=2;
		}
	
	Console.WriteLine("A cos(" + fok +"°) = " +koszin);
	//Console.WriteLine("Az igazi sin(" + fok +") = " + Math.Sin(x));
	}
}