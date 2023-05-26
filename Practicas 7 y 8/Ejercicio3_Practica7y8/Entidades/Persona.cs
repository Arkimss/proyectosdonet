namespace Ejercicio3_Practica7y8;

class Persona : IAtendible, IComercial, IImportante

{
    public Persona()
    { }
    void IComercial.Importa() => Console.WriteLine("Persona Importante");
    void IImportante.Importa() => Console.WriteLine("Persona vendiendo al exterior");
    public override string ToString() => "Persona";
    public void Importa() => Console.WriteLine("Método Importar() de la clase Persona");
    public void atender() => Console.WriteLine($"Atendiendo a una Persona");

}