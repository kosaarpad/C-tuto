using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
	//utf8-as szöveg:
	//foreach (string sor in File.ReadLines("testutf8.txt", Encoding.UTF8))
	
	//windows ANSI szöveg:
	foreach (string sor in File.ReadLines("test1.txt", Encoding.Default))
		{
		Console.WriteLine(sor);
		}
	Console.ReadKey();	
	}
}