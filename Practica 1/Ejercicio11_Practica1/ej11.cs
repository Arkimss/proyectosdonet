// See https://aka.ms/new-console-template for more information
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);

//¿Qué se puede concluir respecto del operador de división “/” ? En una division entre enteros, el resultado va a ser un entero y si el resultado correcto era decimal, se va a perder información
// Si se le agrega un .0 a almenos a uno de los operandos de la división, la división dara un resultado correcto.
// Puede realizarse una división entre una variable integer y una variable double y el resultado sera decimal y correcto.

//¿Cómo funciona el operador + entre un string y un dato numérico? si estan dentro de una instrucción Console.WriteLine() concatena el texto con el dato numerico.

