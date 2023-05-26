namespace Ejercicio1_Practica7y8;

static class Procesador
{
    public static void Alquilar(IAlquilable i, Persona p) => i.alquilar(p);

    public static void Devolver(IAlquilable i, Persona p) => i.devolver(p);
    public static void Secar(ILavable i) => i.secar();
    public static void Lavar(ILavable i) => i.lavar();
    public static void Vender(IVendible i, Persona p) => i.vender(p);

    public static void Atender(IAtendible i) => i.atender();
    public static void Reciclar(IReciclable i) => i.reciclar();



}