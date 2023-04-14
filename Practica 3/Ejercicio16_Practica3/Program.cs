int total = 0;
Console.WriteLine("Ingrese un numero");
string a = Console.ReadLine();
int num;
while (a != "")
{
    try
    {
        num = int.Parse(a);
        total = total + num;
        Console.WriteLine(total);

    }
    catch (FormatException)
    {
        Console.WriteLine(" Se ingresó un caracter invalido ");
    }
    finally
    {
        Console.WriteLine("Ingrese un numero");
        a = Console.ReadLine();
    }
}
Console.ReadKey(true);
