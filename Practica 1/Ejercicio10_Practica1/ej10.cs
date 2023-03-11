// See https://aka.ms/new-console-template for more information

for (int i = 1; i < 1001; i++)
{
    if (((i % 17.0) == 0) | ((i % 29.0) == 0))
        Console.WriteLine(i);
}
