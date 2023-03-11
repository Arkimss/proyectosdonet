// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un año");
int num = int.Parse(Console.ReadLine());

if ((((num % 4 == 0) && (num % 100 != 0))) | (((num % 100 == 0) && (num % 400 == 0)))) // si cumple alguna de las dos pares de condiciones el año es bisiesto, si el numero es divisible por 4 y no por 100, es bisiesto, si es  divisible por 100 y 400 también, de otra manera no lo es.

    Console.WriteLine(" Es un año bisiesto");
else
    Console.WriteLine(" No es un año bisiesto");
Console.ReadKey(true);


// EJERCICIO 16, el problema de la siguiente linea de codigo: if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b); es que en el caso de que la variable b sea 0 el programa tiraria error y cortaria la ejecución del programa, se puede solucionar agregando un &, lo que haria que evalue la primer condición, y al ver que no se cumple sigue con la ejecución normal del programa.