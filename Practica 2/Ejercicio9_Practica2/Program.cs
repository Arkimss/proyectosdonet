// See https://aka.ms/new-console-template for more information
//La clase StringBuilder es una clase que se utiliza para crear cadenas de caracteres mutables
// es decir, que se puede modificar, a diferencia de la clase string, esta clase puede modificarse 
// caracter a caracter, y cuando se le quiere sumar algo a la cadena simplemente modifica la cadena existente, 
// en cambio el string, cada vez que se quiere modificar, crea una cadena nueva.

//programa en el que la clase stringBuilder es más eficiente cuando se cuenta con muchos elementos
using System.Text;
DateTime ini = DateTime.Now;
StringBuilder stb = new StringBuilder("0");
for (int i = 1; i < 10000; i++)
    stb.Append(i);

DateTime fin = DateTime.Now;

Console.WriteLine(fin - ini);
//Console.WriteLine(stb);
DateTime ini2 = DateTime.Now;
//este programa enumera del 1 al 10000, modifican la cadena 10000 veces
string st = "a";
for (int i = 1; i < 10000; i++)
    st = st + i;
DateTime fin2 = DateTime.Now;
Console.WriteLine(fin2 - ini2);
//Console.WriteLine(st);
//en cambio si utilizamos el tipo string, se crearan 10000 cadenas nuevas, lo que no es eficiente.
//Con esta cantidad de elementos el tipo más rapido es el stringBuilder, sin embargo, si se tienen pocos elementos, es más conveniente utilizar el tipo string, por su facil sintaxis y eficiencia.
