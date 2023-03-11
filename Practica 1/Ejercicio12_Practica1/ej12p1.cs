// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número");
string st = Console.ReadLine();
for (int i = 1; i <= int.Parse(st); i++)
{
    if (int.Parse(st) % i == 0)
        Console.WriteLine(i);
}
Console.ReadKey(true);