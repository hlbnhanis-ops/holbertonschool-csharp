using System;
using System.Collections.Generic;

string str_two_digits_0_to_99 = new string("");

for (int i = 0; i <= 9; i++)
{
    for (int j = i + 1; j <= 9; j++)
    {
        if (j != 1)
            str_two_digits_0_to_99 += ", ";
        str_two_digits_0_to_99 += i.ToString() + j.ToString();
    }
}

Console.WriteLine(str_two_digits_0_to_99);
