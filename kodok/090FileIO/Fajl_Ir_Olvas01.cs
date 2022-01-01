using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
	string sor;
	StreamReader sr = new StreamReader("adatok.txt");
	while (!sr.EndOfStream)
		{
		sor = sr.ReadLine();
		Console.WriteLine(sor);
		}
	sr.Close();
	StreamWriter sw1 = new StreamWriter("kimenet.txt", false, Encoding.UTF8);
	//a 2. paraméter false, ha létrehozunk egy új fájlt, true, ha már létezőhöz hozzáírunk
	sor = "Első sor";
	sw1.WriteLine(sor);
	sw1.Close();
	//hozzáírás a már létező szövegfájlhoz:
	StreamWriter swa = new StreamWriter("kimenet.txt", true, Encoding.UTF8);
	//a 2. paraméter false, ha létrehozunk egy új fájlt, true, ha már létezőhöz hozzáírunk
	sor = "Első sor";
	swa.WriteLine(sor);
	swa.Close();
	
	
	}
}