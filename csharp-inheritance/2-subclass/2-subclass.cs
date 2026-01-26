using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType != baseType) && (derivedType is baseType);
    }
}

