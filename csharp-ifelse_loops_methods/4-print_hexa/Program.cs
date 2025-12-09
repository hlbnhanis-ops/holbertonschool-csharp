using System;
using System.Collections.Generic;

List<string> d_hex_0_to_98 = new List<string>();

for (int i = 0; i <= 98; i++)
    d_hex_0_to_98.Add(i.ToString() + " = 0x" + i.ToString("X"));

Console.Write(string.Join("\n", d_hex_0_to_98));
