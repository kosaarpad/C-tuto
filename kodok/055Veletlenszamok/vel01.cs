using System;
public class Program {
   public static void Main() {
      Random r = new Random();
      int veletlenszam = r.Next();
      Console.Write(veletlenszam); //generál egy álvéletlen egész értéket 0 és 2 147 483 647 között
			Console.ReadKey();
   }
}