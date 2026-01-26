using System;

class Obj
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType != null && baseType != null && derivedType != baseType && baseType.IsAssignableFrom(derivedType));
    }
}

