bool EsPrimo(int n)
{
    bool aux = true;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if ((n % i) == 0)
        {
            aux = false;
        }
    }
    return aux;
}
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    if (EsPrimo(i))
        Console.WriteLine(i);
}
Console.ReadKey();