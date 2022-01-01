using System;
//using System.Linq;

namespace Fuggveny03
{
    class Program
    {
        static string forditva(string szov)
        {
            int vege = szov.Length - 1;
            string fordit = "";
            for (int i = vege; i >= 0; i--)
            {

                fordit += szov[i];
            }
            return fordit;
        }
        static bool palindrom(string sz)
        {
            string ford = forditva(sz);
            return ford.Equals(sz);
        }

        static void Main(string[] args)
        {
			Console.WriteLine(forditva("erőszakos"));
			Console.WriteLine(palindrom("görög"));
			Console.WriteLine(palindrom("pörög"));
			for (int i = 100; i < 10000; i++)
			{
				if (palindrom(Convert.ToString(i)))
					{
                    Console.WriteLine(i);
					}
			}
            Console.ReadKey();
        }
    }
}
