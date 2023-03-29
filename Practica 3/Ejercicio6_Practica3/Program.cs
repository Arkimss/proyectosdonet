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

/*public static double CalcularDeterminante(int[,] matriz)
{
    int n = matriz.GetLength(0);
    double determinante = 0;

    if (n == 1)
    {
        determinante = matriz[0, 0];
    }
    else if (n == 2)
    {
        determinante = matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            int[,] submatriz = new int[n - 1, n - 1];
            for (int j = 1; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k < i)
                    {
                        submatriz[j - 1, k] = matriz[j, k];
                    }
                    else if (k > i)
                    {
                        submatriz[j - 1, k - 1] = matriz[j, k];
                    }
                }
            }
            determinante += matriz[0, i] * Math.Pow(-1, i) * CalcularDeterminante(submatriz);
        }
    }

    return determinante;
}
*/
double Determinantes(double[,] m)// tiene que ser  una matriz cuadrada, solo funciona para matrices de 3x3 
{
    double aux;
    if (m.GetLength(0) == 3 && m.GetLength(1) == 3)
    {
        aux = 1 * m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }
    else
    {
        aux = 1 * (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }
    return aux;
}

double[,] A = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };
double[,] B = new double[,] { { 3, 2, 2 }, { 886, 3, 8 }, { 38, 2, 810 } };
try
{
    //double[,] X = Multiplicacion(A, B);
    //Console.WriteLine();
    //ImpMatriz(X);
    Console.WriteLine(Determinantes(A));
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine(" No se puede realizar la Multiplicacion entre matrices");
}