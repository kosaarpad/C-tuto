using System;
public class Program {
   public static void Main() {
      Random r = new Random();
			for (int i=0; i < 10;i++)
				{
				int veletlenszam = r.Next();   //gener�l egy �lv�letlen eg�sz �rt�ket 0 �s 2 147 483 647 k�z�tt
				Console.Write(veletlenszam + ", ");
				}
			Console.ReadKey();
   }
}