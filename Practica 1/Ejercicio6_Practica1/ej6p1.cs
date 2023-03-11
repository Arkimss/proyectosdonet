// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese una linea de texto");
String st = Console.ReadLine();
while (st != "")
{
    Console.WriteLine(" La cadena cuenta con " + " " + st.Length + " " + " Caracteres");
    Console.WriteLine("ingrese una linea de texto");
    st = Console.ReadLine();
}
Console.ReadKey(true);

Console.WriteLine("100".Length);