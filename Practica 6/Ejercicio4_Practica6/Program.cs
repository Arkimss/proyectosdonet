
/*Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto
{
public string Marca { get; private set; } = "Ford";
public Auto(string marca) => this.Marca = marca;
public Auto() { }
}
class Taxi : Auto
{
public int Pasajeros { get; private set; }
public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
// este programa funciona por que la clase auto cuenta con un constructor vacio, lo que permite que la clase Taxi no tenga que invocar el constructor de su clase base.

}
*/
Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}
class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) : base("") => this.Pasajeros = pasajeros;
    // Programa modificado, sin constructor vacio en la clase auto

}
