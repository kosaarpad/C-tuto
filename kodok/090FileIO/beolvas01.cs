using System;
using System.IO;
using System.Text;
class Program
{
static void Main()
	{
  //string[] vers= File.ReadAllLines("test.txt", Encoding.UTF8);
	//string[] vers= File.ReadAllLines("test.txt", Encoding.Default);
	string[] vers= File.ReadAllLines("testutf8.txt");
	foreach (string sor in vers)
		{
		Console.WriteLine(sor);
		}
	Console.ReadKey();	
	}
}