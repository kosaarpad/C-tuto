using System;
using System.IO;
class program
{
	static void Main()
		{
		int counter = 0;  
		string line="";  

		// Read the file and display it line by line.  
		//StreamReader file = new StreamReader(@"c:\test.txt");  
		StreamReader file = new StreamReader("test.txt");  
	   while((line = file.ReadLine()) != null)  
	
			{  
				Console.WriteLine (line);  
				counter++;
				Console.WriteLine(counter);
			}  
		file.Close();  
		Console.WriteLine("There were {0} lines.", counter);  
		// Suspend the screen.  
		Console.ReadLine();  
		}
}