// See https://aka.ms/new-console-template for more information
int num = int.Parse(Console.ReadLine()) * 365;
int dig;
while (num != 0)
{
    dig = num % 10;
    Console.Write(dig + "  ");
    num = num / 10;
}
Console.ReadKey(true);