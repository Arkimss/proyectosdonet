namespace Ejercicio8_Practica6;

class Administrativo : Empleado
{

    public double _Premio { set; get; }

    public Administrativo(string nombre, int dNI, DateTime fechaDeIngreso, double salarioBase) : base(nombre, dNI, fechaDeIngreso, salarioBase)
    {
    }


    public override void AumentarSalario()
    {
        _Salario = _SalarioBase + (_SalarioBase * 0.01 * Antigüedad);
    }
    public override string ToString()
    {
        return "Administrativo: " + base.ToString();
    }

}