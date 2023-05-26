namespace Ejercicio10_Practica7y8;

static class Procesador
{
    public static List<Auto> Opcion1()// cargar autos en una lista
    {
        List<Auto> l = new List<Auto>();
        Auto a;
        do
        {
            a = new Auto();
            Console.WriteLine("Ingrese Marca y modelo del auto");
            a.Marca = Console.ReadLine() ?? "";
            if (!a.Marca.Equals(""))
            {
                a.Modelo = int.Parse(Console.ReadLine() ?? "0");
                l.Add(a);
            }
        }
        while (!a.Marca.Equals(""));
        Console.WriteLine("Fin de carga de la lista");
        return l;
    }
    public static void Opcion3(List<Auto> l)//La opción 3 guarda en un archivo de texto la lista actual en memoria.
    {
        using var sw = new StreamWriter("Auto.txt", true);
        int i = 0;
        while (i < l.Count)
        {
            sw.WriteLine(l[i].Marca);
            sw.WriteLine(l[i].Modelo);
            i++;
        }
        sw.Close();
    }

    public static List<Auto> Opcion2()//La opción 2, carga en memoria una lista de autos previamente guardada en algún archivo de texto.
    {
        using var sw = new StreamReader("Autos.txt", true);
        List<Auto> l = new List<Auto>();
        Auto a = new Auto();
        while (!sw.EndOfStream)
        {
            a.Marca = sw.ReadLine() ?? "";
            a.Modelo = int.Parse(sw.ReadLine() ?? "");
            l.Add(a);
        }
        sw.Close();
        return l;
    }
    public static void Opcion4(List<Auto> l)//La opción 4 produce un listado por consola de todos los autos en la lista actual en memoria.
    {
        int i = 0;
        while (i < l.Count)
        {
            Console.WriteLine(l[i]);
            i++;
        }
    }


}