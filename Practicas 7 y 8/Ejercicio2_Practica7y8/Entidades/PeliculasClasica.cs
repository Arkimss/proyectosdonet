namespace Ejercicio2_Practica7y8;

class PeliculaClasica : Pelicula, IVendible
{

    public PeliculaClasica()
    {

    }
    public override void alquilar(Persona p) => Console.WriteLine($"Pelicula Clasica alquilado a {p}");
    public override void devolver(Persona p) => Console.WriteLine($"Pelicula Clasica devuelta por {p}");

    public void vender(Persona p) => Console.WriteLine($"PeliculaClasica alquilado a {p}");
}