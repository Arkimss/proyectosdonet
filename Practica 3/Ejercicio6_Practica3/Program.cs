double[,]? Suma(double[,] A, double[,] B)
{
    if ((A.GetLength(0) == B.GetLength(0)) & (A.GetLength(1) == B.GetLength(1)))
    {
        double[,]? aux = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                aux[i, j] = A[i, j] + B[i, j];
            }
        }
        return aux;
    }
    else
        return null;
}



double[,]? Resta(double[,] A, double[,] B)
{
    if ((A.GetLength(0) == B.GetLength(0)) & (A.GetLength(1) == B.GetLength(1)))
    {
        double[,]? aux = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                aux[i, j] = A[i, j] - B[i, j];
            }
        }
        return aux;
    }
    else
        return null;
}


double[,] iniMat(double[,] aux)
{
    for (int i = 0; i < aux.GetLength(0); i++)
    {
        for (int j = 0; j < aux.GetLength(1); j++)
        {
            aux[i, j] = 0.0;
        }
    }
    return aux;
}
double[,] Multiplicacion(double[,] A, double[,] B)
{

    double[,]? aux = new double[A.GetLength(0), B.GetLength(1)];
    iniMat(aux);
    for (int i = 0; i < aux.GetLength(0); i++)
    {
        for (int j = 0; j < aux.GetLength(1); j++)
        {
            for (int x = 0; x < B.GetLength(0); x++)
            {
                aux[i, j] = aux[i, j] + (A[i, x] * B[x, j]);// recorro las fila de la matriz A y la multiplico por las columnas de la matriz B, 
                                                            // la nueva matriz se carga fila a fila, es decir  0,0 0,1 0,2, 0n.
                                                            //en la matriz A se avanza entre los elementos de las filas y en la matriz B entre las columnas.
            }

        }
    }
    return aux;
}
void ImpMatriz(double[,] m)
{
    ///   foreach (double a in m)
    //{
    //    Console.Write(a);
    // }

    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i, j],7}"); // con el simbolo $ se pueden crear cadenas interpoladas de strings, si se ponen entre llaves las variables, sus valores se imprimen como strings.
                                           // si se pone una coma luego de la variable y se pone un dato numerico entero, se delimita la cantidad de caracteres que se va a mostrar en pantalla.
        }
        Console.WriteLine();
    }
}


double[,] A = new double[,] { { 4432, 412 } };
double[,] B = new double[,] { { 121, 2, 2, 2 }, { 221, 1232, 321, 32 }, { 21, 123, 231, 32 } };
try
{
    double[,] X = Multiplicacion(A, B);
    Console.WriteLine();
    ImpMatriz(X);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine(" No se puede realizar la Multiplicacion entre matrices");
}