using System;
class Program
{
static void Main()
	{
	string szoveg = "Te �gyes vagy, ugye?\n";
	Console.WriteLine(szoveg);
	string ujszoveg = szoveg.Trim();
	Console.WriteLine(ujszoveg);//csak a "Te �gyes vagy, ugye?" marad, sorv�gjel n�lk�l.
	szoveg = "Te �gyes vagy, ugye?###";
	ujszoveg = szoveg.Trim('#');
	Console.WriteLine(szoveg);
	Console.WriteLine(ujszoveg);//marad a szoveg # n�lk�l
	}
}