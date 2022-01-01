using System;
using System.Linq;
class Program
{
  static string F1(string s)
  {
	string s2="";
	string mh="AEIOUaeiou";
	foreach (char b in s)
		{
			if (!mh.Contains(b))
			{
			s2+=b;	
			}
		}
	return s2;	
  }
  static void Main()
   {
	 Console.WriteLine(F1("Feri"));
   }
}