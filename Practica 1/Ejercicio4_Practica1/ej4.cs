// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Ingrese su nombre");
string st = Console.ReadLine();
if (st != "") // El ejercicio dice que se debe imprimir hola mundo si se ingresa "una linea en blanco"
    Console.WriteLine(" tu nombre es " + " " + st);
else
    Console.WriteLine("Hola Mundo");

Console.ReadKey(true);