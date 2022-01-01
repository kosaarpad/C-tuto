using System;

class Program
{
    static void Main()
    {
        // Use float type.
        float szam = 1.5F;
        Console.WriteLine(szam);
        // Be�ll�tunk egy negat�v �rt�ket:
        szam = -201.001F;
        Console.WriteLine(szam);
        Console.WriteLine(szam == -1.001F); // Egyenl�s�g lek�rdez�s: == oper�tor
        Console.WriteLine(szam + 200); // �sszead�s: a + oper�tor
        Console.WriteLine(szam.GetType());//System.Single-t ad eredm�ny�l
        Console.WriteLine(typeof(float));//System.Single-t ad eredm�ny�l
        Console.WriteLine(float.MinValue.ToString());//a legkisebb �rt�k sz�vegg� konvert�lva
        Console.WriteLine(float.MaxValue.ToString());//a legnagyobb �rt�k sz�vegg� konvert�lva
		Console.WriteLine(float.MinValue.ToString("0"));//a legkisebb �rt�k sz�vegg� konvert�lva
        Console.WriteLine(float.MaxValue.ToString("0"));//a legnagyobb �rt�k sz�vegg� konvert�lva
		Console.WriteLine("szam:"+szam.ToString("0"));//a 
    }
}