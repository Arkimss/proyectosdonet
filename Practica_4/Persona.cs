namespace  Practica_4;
class Persona
{
    int _DNI;
    int _edad;
    string? _Nombre;

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
    public Bool(Persona p)
    {
        return this.GetEdad() > p.GetEdad();
    }
}
