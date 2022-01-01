using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i < 10;i++)
				{
				int veletlenszam = r.Next();   //generál egy álvéletlen egész értéket 0 és 2 147 483 647 között
				Console.Write(veletlenszam + ", ");
				}
			Console.ReadKey();
   }
}