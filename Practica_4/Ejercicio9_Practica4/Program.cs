/*Foo f = new Foo();
f.Imprimir();
class Foo
{
    public void Imprimir()
    {
        string? _bar;
        Console.WriteLine(_bar.Length);// si se pone una variable no inicializada en un metodo no se puede imprimir.
    }
}
*/
Foo f = new Foo();
f.Imprimir();
class Foo
{
string? _bar;
public void Imprimir()
{
Console.WriteLine(_bar.Length);// se inicializa la variable en null, y no se puede imprimir null
}
}