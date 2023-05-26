namespace Ejercicio4_Practica7y8;

class Libro : IAlquilable, IReciclable
{
    public Libro()
    {
    }

    public void reciclar() => Console.WriteLine("Reciclando libro");
    public void alquilar(Persona p) => Console.WriteLine($"Libro alquilado a {p}");
    public void devolver(Persona p) => Console.WriteLine($"Libro devuelto por {p}");
}