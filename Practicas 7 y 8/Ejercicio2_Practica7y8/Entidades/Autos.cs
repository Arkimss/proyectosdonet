namespace Ejercicio2_Practica7y8;

class Autos : IVendible, IReciclable, ILavable
{
    public Autos()
    {
    }
    public void vender(Persona p) => Console.WriteLine($"Alquilando auto a {p}");
    public void lavar() => Console.WriteLine($"Lavando auto ");
    public override string ToString() => "Auto ";
    public void secar() => Console.WriteLine($"Secando  auto ");
    public void reciclar() => Console.WriteLine($"Reciclando auto");

}