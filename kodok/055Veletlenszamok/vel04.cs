using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i < 7;i++)
				{
				double veletlenszam = r.NextDouble();   //gener�l egy �lv�letlen eg�sz �rt�ket 8..30-ig
				Console.WriteLine(veletlenszam);
				}
			Console.ReadKey();
   }
}