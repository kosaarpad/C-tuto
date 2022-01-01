using System;
class Program
{
static void Main()
	{
	string szoveg = "Te ügyes vagy, ugye?\n";
	Console.WriteLine(szoveg);
	string ujszoveg = szoveg.Trim();
	Console.WriteLine(ujszoveg);//csak a "Te ügyes vagy, ugye?" marad, sorvégjel nélkül.
	szoveg = "Te ügyes vagy, ugye?###";
	ujszoveg = szoveg.Trim('#');
	Console.WriteLine(szoveg);
	Console.WriteLine(ujszoveg);//marad a szoveg # nélkül
	}
}