using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
	string[] vers = new string[4];
	vers[0] = "Kedves Szüleim!";
	vers[1] = "Fáznak a füleim!";
	vers[2] = "Küldjetek egy sapkát,";
	vers[3] = "Üdvözlöm a macskát."; 
	File.WriteAllLines("kimenet1.txt", vers, Encoding.UTF8);
	Console.WriteLine("fájl sikeresen létrehozva.");
	Console.ReadKey();	
	}
}
