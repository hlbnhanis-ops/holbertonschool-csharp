using System;
using System.Collections.Generic;

List<char> alphabet = new List<char>();

for (char l = 'a'; l <= 'z'; l++)
{
    if (l != 'q' && l != 'e')
        alphabet.Add(l);
}


Console.Write(string.Join("", alphabet));
