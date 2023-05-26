namespace Ejercicio8_Practica6;

abstract class Empleado
{
    string _nombre { get; }
    public int _DNI { get; }
    public DateTime _FechaDeIngreso { get; }
    public double _SalarioBase { get; protected set; }
    public abstract double _Salario { get; }

    protected int Antigüedad
    {
        get
        {
            DateTime Dia = DateTime.Parse("9/4/2022");
            int years = (Dia.Year - _FechaDeIngreso.Year) > 0 ? Dia.Year - _FechaDeIngreso.Year : 0;
            if (years > 0)
            {
                if ((Dia.Month < _FechaDeIngreso.Month) || ((Dia.Month == _FechaDeIngreso.Month) && (DateTime.Now.Day < _FechaDeIngreso.Day)))
                    years--;
            }
            return years;
        }
    }

    protected Empleado(string nombre, int dNI, DateTime fechaDeIngreso, double salarioBase)
    {
        _nombre = nombre;
        _DNI = dNI;
        _FechaDeIngreso = fechaDeIngreso;
        _SalarioBase = salarioBase;
    }
    public abstract void AumentarSalario();
    public override string ToString()
    {
        return $"Nombre: {_nombre}, DNI: {_DNI}, Antiguedad {Antigüedad}\n Salario Base: {_SalarioBase}, Salario: {_Salario}\n -----------------------";
    }
}