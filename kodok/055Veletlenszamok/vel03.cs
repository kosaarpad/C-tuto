using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i <10; i++)
				{
				int veletlenszam = r.Next(21);   //generál egy álvéletlen egész értéket 0..20-ig
				Console.Write(veletlenszam + ", ");
				}
			Console.ReadKey();
   }
}