// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i = 10;
var x = i * 1.0;
var y = 1f;
var z = i * y;
Console.WriteLine(i.GetType());//i es int
Console.WriteLine(x.GetType());// x es double
Console.WriteLine(y.GetType());//y es string nop, es single
Console.WriteLine(z.GetType());// es int?, single

// single: el tipo de datos Single para incluir valores de punto flotante que no requieren el ancho completo de datos de Double. 