using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
            System.Console.WriteLine(new string(' ', i) + '\\');
        System.Console.WriteLine();
    }
}