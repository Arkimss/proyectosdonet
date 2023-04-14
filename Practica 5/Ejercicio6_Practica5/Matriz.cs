namespace Ejercicio6_Practica5;

public class Matriz
{
    double[,] M;

    public Matriz(int filas, int columnas)
    {
        M = new double[filas, columnas];
    }

    public Matriz(double[,] matriz)
    {
        M = matriz;
    }
    public double this[int i, int j]
    {
        get
        {
            return M[i, j];
        }
        set
        {
            M[i, j] = value;
        }
    }
    public void imprimir()
    {
        foreach (double st in M)
        {
            Console.WriteLine(st);
        }
    }
    public void imprimir(string formatString)
    {
        for (int i = 0; i <= M.GetLength(0); i++)
        {
            for (int j = 0; j <= M.GetLength(1); j++)
            {
                Console.WriteLine($"{M[i, j].ToString(formatString),7}");
            }
            Console.WriteLine();
        }
    }

    public double[] GetFila(int fila)
    {
        double[] aux = new double[M.GetLength(0)];
        for (int i = 0; i < M.GetLength(0); i++)
        {
            aux[i] = M[fila, i];
        }
        return aux;
    }
    public double[] GetColumna(int columna)
    {
        double[] aux = new double[M.GetLength(1)];
        for (int i = 0; i < M.GetLength(0); i++)
        {
            aux[i] = M[i, columna];
        }
        return aux;
    }
    public double[] GetDiagonalPrincipal
    {
        get
        {
            double[] aux = new double[M.GetLength(1)];
            try
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    aux[i] = M[i, i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"No se puede agregar el elemento porque la cantidad de columnas es menor a la de filas");
            }
            return aux;
        }
    }
    public double[] GetDiagonalSecundaria
    {
        get
        {
            double[] aux = new double[M.GetLength(0)];
            int ult = M.GetLength(1);
            try
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    aux[i] = M[i, ult - i - 1];
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"No se puede agregar el elemento porque la cantidad de columnas es menor a la de filas");
            }
            return aux;
        }
    }
    public double[][] getArregloDeArreglo()
    {
        double[][] aux = new double[M.GetLength(0)][];
        for (int i = 0; i < M.GetLength(1); i++)
        {
            aux[i] = new double[M.GetLength(1)];
        }
        for (int i = 0; i <= M.GetLength(0); i++)
        {
            for (int j = 0; j <= M.GetLength(1); j++)
            {
                aux[i][j] = M[i, j];
            }
        }
        return aux;
    }
    public void sumarle(Matriz m)
    {
        if ((M.GetLength(0) == m.M.GetLength(0)) && (M.GetLength(1) == m.M.GetLength(1)))
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] += m.M[i, j];
                }
            }
        }
    }
    public void restarle(Matriz m)
    {
        if ((M.GetLength(0) == m.M.GetLength(0)) && (M.GetLength(1) == m.M.GetLength(1)))
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] -= m.M[i, j];
                }
            }
        }
    }
    public void multiplicarPor(Matriz B)
    {

        if (M.GetLength(0) == B.M.GetLength(1))
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    for (int x = 0; x < B.M.GetLength(0); x++)
                    {
                        M[i, j] = M[i, j] + (M[i, x] * B.M[x, j]);
                    }
                }
            }// Esto esta mal
             // Preguntar, solo se hace si las matrices son de las mismas dimensiones? o tengo que crear una nueva matriz y asignarle el resultado a la variable de instancia?
        }
    }
}
