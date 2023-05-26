namespace Ejercicio6_Practica7y8;
class ComparadorLongitudNombre : System.Collections.IComparer
{
    public int Compare(object? x, object? y)
    {
        int result = 1;
        if (x is INombrable && y is INombrable)
        {
            int i1 = ((INombrable)x).Nombre.Length;
            int i2 = ((INombrable)y).Nombre.Length;
            result = i1.CompareTo(i2);
        }
        return result;
    }
}
