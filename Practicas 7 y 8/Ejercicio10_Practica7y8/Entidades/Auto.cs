namespace Ejercicio10_Practica7y8;

class Auto
{
    public string Marca { get; set; } = "";
    public int Modelo { get; set; }

    public override string ToString()
    {
        return $"Marca {Marca}, Modelo {Modelo}";
    }
}