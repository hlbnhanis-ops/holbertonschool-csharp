using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType != null && baseType != null && derivedType != baseType && baseType.IsAssignableFrom(derivedType));
    }
}

