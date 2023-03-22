// See https://aka.ms/new-console-template for more information
//el metodo split es utilizado para dividir
//una cadena de caracteres en sub cadenas a partir de un delimitador.

string st = Console.ReadLine();//cadena string, con palabras separadas por el caracter ' '
char delimitador = ' ';
string[] subcadenas = st.Split(delimitador);//se toma un string y mediante un delimitador se separan las palabras.nose cual es la manera de saber cuantos elementos tiene el vector con la subcadena    


//¿el foreach se utiliza cuando no se sabe cundo termina el vector a recorrer?
foreach (string s in subcadenas)
{
    Console.WriteLine(s);
}
Console.ReadKey(true);