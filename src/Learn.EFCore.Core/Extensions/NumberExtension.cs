namespace Learn.EFCore.Core.Extensions;

public static class NumberExtension
{
    public static bool IsNotPositive(this long source) 
    {
        return source < 1;
    }

    public static bool IsNotPositive(this int source) 
    {
        return source < 1;
    }
}

