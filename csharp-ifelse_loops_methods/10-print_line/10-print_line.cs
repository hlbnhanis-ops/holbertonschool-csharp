public class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
            System.Console.WriteLine(new string('_', length));
        System.Console.WriteLine();
        return;
    }
}