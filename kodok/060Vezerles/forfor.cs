using System;
class Program
{
	static void Main()
	{
	char betu;
	int jegy;
	for ( betu='A'; betu < 'G';betu++ )
	    {
		for ( jegy=1; jegy <= 5;jegy++ )
			Console.Write(betu+"---"+jegy+"  ");
		Console.WriteLine();//betûváltás után új sor
		}
	}
}