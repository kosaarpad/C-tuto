using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i < 7;i++)
				{
				double veletlenszam = r.NextDouble();   //generál egy álvéletlen egész értéket 8..30-ig
				Console.WriteLine(veletlenszam);
				}
			Console.ReadKey();
   }
}