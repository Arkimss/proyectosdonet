using Ejercicio10_Practica7y8;
var l = new List<Auto>();// se carga mediante la lectura de autos por consola
var l2 = new List<Auto>();// se carga en la opcion 2, desde el disco
ConsoleKeyInfo tecla;
do
{

    ImprimirOpciones();
    tecla = Console.ReadKey(true);
    switch (tecla.KeyChar)
    {
        case '1':
            l = Procesador.Opcion1();
            break;
        case '2':
            l2 = Procesador.Opcion2();
            break;
        case '3':
            Procesador.Opcion3(l);
            break;
        case '4':
            Procesador.Opcion4(l);
            break;

    }
} while (tecla.KeyChar != '5');



void ImprimirOpciones()
{
    Console.WriteLine("Menú de Opciones");
    Console.WriteLine("----------------");
    Console.WriteLine("----------------");
    Console.WriteLine("1. Ingresar autos desde la consola");
    Console.WriteLine("2. Cargar lista de autos desde el disco");
    Console.WriteLine("3. Guardar lista de autos en el disco");
    Console.WriteLine("4. Listar en consola");
    Console.WriteLine("5. Salir");
    Console.WriteLine();
    Console.WriteLine("Ingrese su opcion");
}