using System;

class Obj
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
