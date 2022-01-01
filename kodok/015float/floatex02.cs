using System;

class Program
{
    static void Main()
    {
        // Use float type.
        float szam = 1.5F;
        Console.WriteLine(szam);
        // Beállítunk egy negatív értéket:
        szam = -201.001F;
        Console.WriteLine(szam);
        Console.WriteLine(szam == -1.001F); // Egyenlõség lekérdezés: == operátor
        Console.WriteLine(szam + 200); // Összeadás: a + operátor
        Console.WriteLine(szam.GetType());//System.Single-t ad eredményül
        Console.WriteLine(typeof(float));//System.Single-t ad eredményül
        Console.WriteLine(float.MinValue.ToString());//a legkisebb érték szöveggé konvertálva
        Console.WriteLine(float.MaxValue.ToString());//a legnagyobb érték szöveggé konvertálva
		Console.WriteLine(float.MinValue.ToString("0"));//a legkisebb érték szöveggé konvertálva
        Console.WriteLine(float.MaxValue.ToString("0"));//a legnagyobb érték szöveggé konvertálva
		Console.WriteLine("szam:"+szam.ToString("0"));//a 
    }
}