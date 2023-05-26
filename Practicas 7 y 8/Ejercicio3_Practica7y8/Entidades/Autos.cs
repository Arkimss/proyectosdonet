namespace Ejercicio3_Practica7y8;

class Autos : IVendible, IReciclable, ILavable, IComercial, IImportante
{
    public Autos()
    { }
    void IComercial.Importa() => Console.WriteLine("Auto que se vende al exterior");
    void IImportante.Importa() => Console.WriteLine("Auto Importante");
    public void Importa() => Console.WriteLine("Método Importar() de la clase autos");
    public void vender(Persona p) => Console.WriteLine($"Alquilando auto a {p}");
    public void lavar() => Console.WriteLine($"Lavando auto ");
    public override string ToString() => "Auto";
    public void secar() => Console.WriteLine($"Secando auto");
    public void reciclar() => Console.WriteLine($"Reciclando auto");
}