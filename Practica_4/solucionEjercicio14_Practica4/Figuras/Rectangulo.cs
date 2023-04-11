namespace Figuras;
public class Rectangulo
{
    double _base;
    double _altura;

    public Rectangulo(double b, double altura)
    {
        _base = b;
        _altura = altura;
    }
    public double GetArea()
    {
        return _altura * _base;
    }
}
