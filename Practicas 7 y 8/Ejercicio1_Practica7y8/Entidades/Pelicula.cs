namespace Ejercicio1_Practica7y8;

class Pelicula : IAlquilable
{
    public Pelicula()
    {
    }
    public void alquilar(Persona p) => Console.WriteLine($"Pelicula alquilado a {p}");
    public void devolver(Persona p) => Console.WriteLine($"Pelicula devuelta por {p}");
}