namespace Ejercicio8_Practica6;

class Vendedor : Empleado
{
    public Vendedor(string nombre, int dNI, DateTime fechaDeIngreso, double salarioBase) : base(nombre, dNI, fechaDeIngreso, salarioBase)
    {
    }
    public double _Comision { set; get; }

    public override void AumentarSalario()
    {

        double Aumento = Antigüedad < 10 ? _SalarioBase * 0.05 : _SalarioBase * 0.1;
        _Salario = _SalarioBase + Aumento;
    }

    public override string ToString()
    {
        return "Vendedor: " + base.ToString();
    }
}