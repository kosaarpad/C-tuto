using System;

public class Test
{
    static void Main()
    {
      string szoveg = "23zz";
			int szam;
			szam = Convert.ToInt32(szoveg);
			Console.WriteLine(szam);//23
			Console.WriteLine(szam+2);//25
			Console.WriteLine(szoveg+2);//232
    }
}