
using System.Collections;
IEnumerable potencias = Potencias(2, 10);

Console.WriteLine();
foreach (int i in potencias)
{
    Console.Write(i + " ");
}



IEnumerable Potencias(double b, int k)
{
    for (int i = 1; i <= k; i++)
    {
        yield return Math.Pow(b, i);
    }

}















