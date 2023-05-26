namespace Ejercicio4_Practica7y8;

class Perro : IAtendible, IVendible, ILavable, INombrable, IComparable
{
    string _Nombre = "";
    public Perro()
    {


    }
    public string Nombre
    {
        get => _Nombre;
        set => _Nombre = value;
    }
    public override string ToString()
    {
        return $"{Nombre} es un perro";
    }
    public void atender() => Console.WriteLine($"Atendiendo a un Perro");
    public void lavar() => Console.WriteLine($"Lavando a un Perro");
    public void secar() => Console.WriteLine($"Secando a un Perro");

    public void vender(Persona p) => Console.WriteLine($" vendiendo perro a {p}");

    public void devolver(Persona p) => Console.WriteLine($" Perro devuelto por {p}");

    public int CompareTo(object? obj)
    {
        int result = 0;
        if (obj is INombrable)
        {
            string nombre = ((INombrable)obj).Nombre;
            result = this.Nombre.CompareTo(nombre);
        }
        return result;
    }
}