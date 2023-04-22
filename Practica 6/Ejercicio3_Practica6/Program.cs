class Auto
{
    protected double velocidad;// se le debe agregar el modificador de acceso protected a la variable para que pueda ser accedida por su subclase.
    public virtual void Acelerar()
    => Console.WriteLine("Velocidad = {0}", velocidad += 10);
}
class Taxi : Auto
{
    public override void Acelerar()
    => Console.WriteLine("Velocidad = {0}", velocidad += 5);
}
