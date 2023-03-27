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
            Console.Write(m[i, j] + ' ');
        }
        Console.WriteLine();
    }

}

double[,] m = new double[,]{{1, 2 ,3 },
                            {4, 5, 6} };
ImpMatriz(m);