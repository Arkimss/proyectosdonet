namespace Ejercicio6_Practica7y8;

class Persona : IAtendible, IComercial, IImportante, INombrable, IComparable

{
    public string Nombre
    {
        get => Nombre;
        set => Nombre = value;
    }
    public Persona()
    { }


    void IComercial.Importa() => Console.WriteLine("Persona Importante");
    void IImportante.Importa() => Console.WriteLine("Persona vendiendo al exterior");
    public override string ToString() => $"{Nombre} es una Persona";
    public void Importa() => Console.WriteLine("Método Importar() de la clase Persona");
    public void atender() => Console.WriteLine($"Atendiendo a una Persona");

    public int CompareTo(object? obj)
    {
        int result = 0;
        if (obj is INombrable)
        {
            if (obj is Persona)
            {
                string nombre = ((INombrable)obj).Nombre;
                result = this.Nombre.CompareTo(nombre);
            }
            else
            {
                return -1;
            }
        }
        return result;
    }
}