using System;

class Program
{
    static void Main()
    {
        // double, osztva egésszel:
        double a = 8;
		int b = 3;
        Console.WriteLine("double/int: 8/3="+a/b);
        //egész, osztva double-al: 
        int a1=8;
		double b1 = 3;
        Console.WriteLine("int/double: 8/3="+a1/b1);
		//double, osztva double-al: 
        int a2=8;
		double b2 = 3;
        Console.WriteLine("double/double: 8/3="+a2/b2);
		//egész osztva egésszel
		Console.WriteLine("Na DE:");
		int a3=8;
		int b3 = 3;
		Console.WriteLine("int/int: 8/3="+a3/b3);
    }
}