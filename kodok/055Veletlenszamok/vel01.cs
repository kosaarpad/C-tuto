using System;
public class Program {
   public static void Main() {
      Random r = new Random();
      int veletlenszam = r.Next();
      Console.Write(veletlenszam); //gener�l egy �lv�letlen eg�sz �rt�ket 0 �s 2 147 483 647 k�z�tt
			Console.ReadKey();
   }
}