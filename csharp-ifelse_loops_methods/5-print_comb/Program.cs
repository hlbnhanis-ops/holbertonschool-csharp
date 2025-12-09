using System;
using System.Collections.Generic;

string[] str_two_digits_0_to_99 = new string[100];

for (int i = 0; i <= 99; i++)
{
    str_two_digits_0_to_99[i] = i.ToString("D2");
}

Console.WriteLine(string.Join(", ", str_two_digits_0_to_99));
