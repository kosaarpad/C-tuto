using System.Collections.Generic;

// Create a List, and it can only contain integers.
List<int> termList = new List<int>();

for (int i = 0; i < 400; i++)
{
   termList.Add(i);
}
int[] terms = termList.ToArray();