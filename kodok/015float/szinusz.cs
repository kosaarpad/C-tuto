using System;

class Program
{
    static void Main(string[] args)
    {
	string ertek;
	double fok, x, x2, tag, szin, akthiba, hiba;
	int n;
	Console.WriteLine("Ez a program kiszámítja egy adott szög(0..90°) szinuszát.");
	Console.WriteLine("Hány fokos a szög? (0..90)");
	ertek = Console.ReadLine();
	
	fok = Convert.ToDouble(ertek);
	x=fok*3.14159265358979323846/180;
	//x=fok*Math.PI/180;
	akthiba=1;
	szin=x;
	tag=x;
	hiba=1e-20;
	//elojel=1;//ezzel az előjel változóval a program kerekítési hibákat ad.
	n=3;
	x2=x*x;
	while (akthiba>hiba)
	    {
		 //elojel=-elojel;
		 tag = -tag*x2/((n-1)*n); 
		 szin = szin + tag;
		 if (tag<0) akthiba=-tag;
		 else akthiba=tag;
		 Console.WriteLine("n = "+n+"  akthiba = " + akthiba);
		 n+=2;
		}
	
	Console.WriteLine("A sin(" + fok +"°) = " +szin);
	//Console.WriteLine("Az igazi sin(" + fok +") = " + Math.Sin(x));
	}
}