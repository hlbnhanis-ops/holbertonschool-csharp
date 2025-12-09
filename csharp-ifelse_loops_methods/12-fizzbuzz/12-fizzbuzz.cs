class Fizzbuzz
{
    public static void Fn_Fizzbuzz()
    {
        System.Console.Write(1 + " ");
        for (int i = 2; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                    System.Console.Write(" Fizzbuzz");
                else
                    System.Console.Write(" Fizz");
            }
            else if (i % 5 == 0)
                System.Console.Write(" Buzz");
            else
                System.Console.Write(" " + i);
        }
        System.Console.WriteLine();
    }
}