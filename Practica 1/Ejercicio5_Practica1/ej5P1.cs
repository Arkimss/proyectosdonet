// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Ingrese su nombre");
string st = Console.ReadLine();
if (st == "Juan")
    Console.WriteLine("¡Hola amigo");
else
    if (st == "Maria")
    Console.WriteLine("Buen dia señora");
else
        if (st == "Alberto")
    Console.WriteLine("Hola Alberto");
else
            if (st == "")
    Console.WriteLine("Buen dia mundo");
else
    Console.WriteLine(" Buen dia" + st);

Console.ReadKey(true);
switch (st)
{
    case "Juan":
        Console.WriteLine("¡Hola amigo");
        break;
    case "Maria":
        Console.WriteLine("Buen dia señora");
        break;
    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;
    case "":
        Console.WriteLine("Buen dia Mundo");
        break;
    default:
        Console.WriteLine("buen dia" + st);
        break;

}
Console.ReadKey(true);