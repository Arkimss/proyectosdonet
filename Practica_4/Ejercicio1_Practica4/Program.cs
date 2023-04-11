using Practica4;
Console.WriteLine("Hello, World!");

// NOSE COMO SE USA LA FUNCION Console.SetIn(new System.IO.StreamReader("Personas.txt"));
for (int i = 0; i < 4; i++)
{
    Persona p = new Persona(15 + i, 45569520 + i, "Acosta" + i);
    Console.WriteLine(i + ")" + p.toString()); // en el 1 debia imprimir normal pero imprimí con un metodo de la clase, como pide el ejercicio 2
}
Console.ReadKey(true);