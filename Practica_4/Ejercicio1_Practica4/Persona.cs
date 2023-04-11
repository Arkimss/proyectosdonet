namespace Practica4;
class Persona
{
    private int _DNI;
    private int _edad;
    private string? _Nombre;

    public Persona(int edad, int dni, string nombre)
    {
        _DNI = dni;
        _edad = edad;
        _Nombre = nombre;
    }
    public string toString()
    {
        return $"  DNI: {this._DNI,-15} Nombre: {this._Nombre,-20} Edad: {this._edad,-4}";
    }
    public int GetEdad()
    {
        return _edad;
    }
    public Boolean EsMayorQue(Persona p)
    {
        return p.GetEdad() < this.GetEdad();// la persona que recibe el mensaje es mayor que la persona que se pasa como parametro?
    }
}
