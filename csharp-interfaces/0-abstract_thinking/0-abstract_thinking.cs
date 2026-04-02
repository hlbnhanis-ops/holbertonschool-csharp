using System;

/// <summary>
/// 
/// </summary>
public abstract class Base
{
    /// <summary>
    /// 
    /// </summary>
    public string name;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return String.Concat(name, " is a ", this.GetType().ToString());
    }
}