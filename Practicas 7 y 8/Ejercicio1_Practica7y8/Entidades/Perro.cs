namespace Ejercicio1_Practica7y8;

class Perro : IAtendible, IVendible
{
    public Perro()
    {

    }
    public void atender() => Console.WriteLine($"Atendiendo a un Perro");

    public void vender(Persona p) => Console.WriteLine($" vendiendo perro a {p}");

    public void devolver(Persona p) => Console.WriteLine($" Perro devuelto por {p}");
}