using System;

class Program
{
	static void Main()
		{
		int n;
		n = 0;
		while(n < 10)
			{
			if (n == 5) 
				{
				n++;
				continue;
				}
			Console.WriteLine("n = "+n);
			n++;
			}
		}
}