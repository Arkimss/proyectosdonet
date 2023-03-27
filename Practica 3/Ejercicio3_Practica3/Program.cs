// See https://aka.ms/new-console-template for more information
void ImprimirMatrizConFormato(double[,] m, string st)
{
    ///   foreach (double a in m)
    //{
    //    Console.Write(a);
    // }

    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i, j].ToString(st),7}"); // con el simbolo $ se pueden crear cadenas interpoladas de strings, si se ponen entre llaves las variables, sus valores se imprimen como strings.
                                                        // si se pone una coma luego de la variable y se pone un dato numerico entero, se delimita la cantidad de caracteres que se va a mostrar en pantalla.
        }
        Console.WriteLine();
    }

}

double[,] m = new double[,]{{1, 2 ,3 },
                            {4, 5, 6} };
ImprimirMatrizConFormato(m, "0.0");