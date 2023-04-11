namespace Ejercicio6_Practica4;
class Ecuacion2
{
    double a;
    double b;
    double c;

    public Ecuacion2(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double GetDiscriminante()
    {
        return ((this.b * this.b) - (4 * this.a * this.c));
    }
    public int GetCantidadDeRaices()
    {
        double aux = this.GetDiscriminante();
        return aux < 0 ? 0 : aux == 0 ? 1 : 2;// si el discriminante es menor a 0 no tiene raices, si es igual, tiene una raiz y sino se retorna 2.
    }

    public string imprimir()
    {
        int aux = this.GetCantidadDeRaices();
        string auxs;
        if (aux == 2)
        {
            auxs = -this.b + ((Math.Sqrt(this.GetDiscriminante()) / 2 * a)) + " " + (-this.b - ((Math.Sqrt(this.GetDiscriminante())) / 2 * this.a));
        }
        else
            if (aux == 1)
        {
            auxs = $"{this.GetDiscriminante()}";
        }
        else
        {
            auxs = " No tiene raices en los reales";
        }
        return auxs;
    }
}