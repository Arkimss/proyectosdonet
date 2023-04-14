Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);
class Auto
{
    private string marca;
    public string Marca
    {
        set
        {
            Marca = value;
        }
        get
        {
            return marca;
        }
    }
}
// el problema de este codigo se encuentra en el setter, se le asigna el nuevo valor a la propiedad Marca en vez de a la variable de instancia marca.