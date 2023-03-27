double[] GetDiagonalPrincipal(double[,] matriz)
{
    Console.WriteLine("Diagonal Primaria");
    double[] aux = new double[matriz.GetLength(0)];
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        aux[i] = matriz[i, i];
    }
    return aux;
}
double[] GetDiagonalSecundaria(double[,] matriz)
{
    Console.WriteLine("Diagonal secundaria");
    double[] aux = new double[matriz.GetLength(0)];
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        aux[i] = matriz[i, (matriz.GetLength(0) - 1) - i];// como el indice de un vector inicia en 0, el ultimo elemento se va a encontrar en GetLength -1, luego le resto i para imprimir los anteriores, la fila avanza normal con el for.
    }
    return aux;
}
void ImpVector(double[] v)
{
    for (int i = 0; i < v.GetLength(0); i++)
    {
        Console.Write($"{v[i],4}");
    }
}




double[,] c = new double[,] { { 1.9, 2, 9 }, { 1, 2, 3 }, { 9.0, 9, 2.0 }, { 9, 8, 9 } };
try
{
    ImpVector(GetDiagonalSecundaria(c));
    Console.WriteLine();
    ImpVector(GetDiagonalPrincipal(c));
    Console.WriteLine();
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Fuera de rango maestro");
}
catch
{
    Console.WriteLine("NOOOOOOOOOOOO");
}

