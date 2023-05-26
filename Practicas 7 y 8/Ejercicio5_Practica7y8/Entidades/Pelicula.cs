namespace Ejercicio5_Practica7y8;

class Pelicula : IAlquilable
{
    public Pelicula()
    {
    }
    public virtual void alquilar(Persona p) => Console.WriteLine($"Pelicula alquilado a {p}");
    public virtual void devolver(Persona p) => Console.WriteLine($"Pelicula devuelta por {p}");
}