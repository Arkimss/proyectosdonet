string[] vector = new string[4] { "Acosta", "Ale", "Pedro", "Juan" };

/*void saludar(string[] v)
{
    for (int i = 0; i < v.Length; i++)
    {
        Console.WriteLine("Hola " + v[i]);
    }
    return;
}
*/
void saludar(string[] v)
{
    foreach (string st in vector)
    {
        Console.WriteLine("Hola " + st);
    }
    return;
}
saludar(vector);
