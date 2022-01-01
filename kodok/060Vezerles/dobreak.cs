using System;
class Program
{
	static void Main()
	{
	int n;
	n=0;
	do
		{
		if (n==5) break;
		Console.WriteLine("n = "+n);
		n++;
		}
	while(n<10);
	}
}