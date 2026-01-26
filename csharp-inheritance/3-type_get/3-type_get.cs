using System;

class Obj
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Console.WriteLine(String.Format("{0} Properties:", myObj.GetType().Name));
        foreach (var i in myObj.GetType().GetProperties())
        {
            Console.WriteLine(i.ToString());
        }
        foreach (var i in myObj.GetType().GetMethods())
        {
            Console.WriteLine(i.ToString());
        }
    }
}
