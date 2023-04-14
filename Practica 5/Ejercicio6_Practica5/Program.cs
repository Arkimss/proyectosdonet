using Ejercicio6_Practica5;
Console.WriteLine("Hello, World!");
Matriz ma = new Matriz(12, 2);
ma[0, 1] = 3;
ma[1, 1] = 1;
ma[0, 0] = 0;
ma[2, 0] = 4;
double[] vec = ma.GetDiagonalPrincipal;
foreach (double d in vec)
{
    Console.WriteLine(d);
}