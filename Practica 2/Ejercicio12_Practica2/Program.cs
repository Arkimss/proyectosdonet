// See https://aka.ms/new-console-template for more information

using System.Text;
object[] v = new object[10];
v[0] = new StringBuilder("Net");
for (int i = 1; i < 10; i++)
{
    v[i] = v[i - 1];
}
(v[5] as StringBuilder).Insert(0, "Framework .");
foreach (StringBuilder s in v)
    Console.WriteLine(s);
//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución

// Todos los elementos del vector tiene un tipo de referencia en la pila y apuntan al mismo elemento en memoria dinamica.


v[5] = new StringBuilder("CSharp");
foreach (StringBuilder s in v)
    Console.WriteLine(s);
//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución


// Ahora todos los elementos del vector siguen apuntando al mismo elemento, excepto el v[5] que apunta a otra dirección.    