object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o);//tods imprimen 5 y 5, segundo metodo, en el primero se espera un int.
s.Procesar((dynamic)o, o);//primer metodo pasa un int y un object
s.Procesar((dynamic)o, (dynamic)o);//primer metodo porque se pasan 2 int al hacer la conversion explicita
s.Procesar(o, (dynamic)o);//segundo metodo porque pasa un obj y el dynamic lo toma, el primero metodo no, porque se espera un int.
s.Procesar(5, 5);//primer metodo porque pasa un int y un object
class Sobrecarga
{
    public void Procesar(int i, object o)
    {
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2)
    {
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");//imprime 2 int
    }
}