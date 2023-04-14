
Stack<int> Pila = new Stack<int>();
int Base10_ = 51;
int res;
while (Base10_ != 0)
{
    res = Base10_ % 2;
    Base10_ = Base10_ / 2;
}
while (Pila.Count > 0)
{
    Console.WriteLine(Pila.Pop());// Porque cuando se desapila los elementos deben imprimirse en lines separadas?
}
