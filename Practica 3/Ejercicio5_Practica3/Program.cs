double[][] GetArregloDeArreglo(double[,] matriz)
{
    double[][] aux = new double[matriz.GetLength(0)][]; //creo el vector de vectores con la cantidad de filas que tiene la matriz.
    for (int i = 0; i < matriz.GetLength(0); i++) // le asigno a todas las filas del vector de vectores la misma cantidad de columnas.
    {
        aux[i] = new double[matriz.GetLength(1)];
    }
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            aux[i][j] = matriz[i, j];
        }
    }
    return aux;
}
double[,] m = new double[,] { { 1, 2, 3 }, { 2, 4, 6 } };
GetArregloDeArreglo(m);

