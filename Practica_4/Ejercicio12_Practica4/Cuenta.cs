namespace Ejercicio12_practica4;
class Cuenta
{
    private double _monto;
    private int _titularDNI;
    private string? _titularNombre;

    public Cuenta()
    {
        _monto = 0.0;
        _titularDNI = 0;
        _titularNombre = "No Especificado";
    }
    public Cuenta(int DNI) : this()
    {
        this._titularDNI = DNI;

    }
    public Cuenta(string nombre) : this()
    {
        _titularNombre = nombre;
    }
    public Cuenta(string nombre, int DNI) : this()
    {
        this._titularDNI = DNI;
        this._titularNombre = nombre;
    }

    public void Depositar(double monto)
    {
        this._monto = this._monto + monto;
    }
    public void Extraer(double monto)
    {
        double aux = this._monto - monto;
        if (aux < 0)
        {
            Console.WriteLine("Operacion cancelada, monto insuficiente");
        }
        else
        {
            this._monto = aux;
        }
    }
    public void Imprimir()
    {
        string aux = _titularDNI == 0 ? "No Especificado" : $"{_titularDNI}";
        Console.WriteLine($"Nombre : {this._titularNombre}, DNI:  {aux}, Monto: {this._monto}");
    }
}