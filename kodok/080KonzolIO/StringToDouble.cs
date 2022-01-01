using System;

public class Test
{
    static void Main()
    {
      string szoveg = "3,14";
			double szam;
			szam = Convert.ToDouble(szoveg);
			Console.WriteLine(szam);//3.14;
			Console.WriteLine(2*szam);//6.28;
    }
}