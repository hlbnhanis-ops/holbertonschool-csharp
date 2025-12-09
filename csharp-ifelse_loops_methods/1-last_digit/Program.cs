using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int ssid = 0;
        string[] ss = { "and is greater than 5", "and is 0", "and is less than 6 and not 0" };
        if (number < 6)
        {
            if (number == 0)
            {
                ssid = 1;
            }
            else
            {
                ssid = 2;
            }
        }

        Console.WriteLine("The last digit of {0} is {1} {2}", number, Math.Abs(number % 10), ss[ssid]);
    }
}