// See https://aka.ms/new-console-template for more information
int fib(int n)
{
    return n <= 2 ? 1 : fib(n - 1) + fib(n - 2);
}
Console.WriteLine(fib(4));