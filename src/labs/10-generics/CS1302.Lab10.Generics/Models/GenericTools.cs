namespace CS1302.Lab10.Generics.Models;

public static class GenericTools
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
