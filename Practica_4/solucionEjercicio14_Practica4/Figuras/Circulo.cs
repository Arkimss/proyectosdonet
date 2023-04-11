namespace Figuras;
public class Circulo
{
    double _Radio;

    public Circulo(double radio)
    {
        _Radio = radio;
    }
    public Circulo(int radio)
    {
        _Radio = radio;
    }
    public double GetArea()
    {
        return 3.14159265358979 * Math.Pow(_Radio, 2);
    }

}