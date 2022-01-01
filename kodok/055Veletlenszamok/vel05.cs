using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i < 20;i++)
				{
				double veletlenszam = -2+r.NextDouble()*6;   //generál egy álvéletlen egész értéket 8..30-ig
				Console.WriteLine(veletlenszam);
				}
			Console.ReadKey();
   }
}