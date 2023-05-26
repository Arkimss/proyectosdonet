namespace Ejercicio1_Practica7y8;

class Persona : IAtendible

{
    public Persona()
    {
    }
    public override string ToString() => "Persona";

    public void atender()
    {
        Console.WriteLine($"Atendiendo a una Persona");
    }
}