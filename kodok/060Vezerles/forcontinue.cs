using System;

class Program
{
	static void Main()
		{
		int n;
		for ( n=0; n < 10; n++)
			{
			if (n == 5) 
				{
				continue;
				}
			Console.WriteLine("n = "+n);
			}
		}
}