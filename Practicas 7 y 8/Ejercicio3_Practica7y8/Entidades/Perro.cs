namespace Ejercicio3_Practica7y8;

class Perro : IAtendible, IVendible, ILavable
{
    public Perro()
    {


    }
    public void atender() => Console.WriteLine($"Atendiendo a un Perro");
    public void lavar() => Console.WriteLine($"Lavando a un Perro");
    public void secar() => Console.WriteLine($"Secando a un Perro");

    public void vender(Persona p) => Console.WriteLine($" vendiendo perro a {p}");

    public void devolver(Persona p) => Console.WriteLine($" Perro devuelto por {p}");
}