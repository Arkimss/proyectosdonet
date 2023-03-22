object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);
//el resultado de la consola no es Z Z porque luego que o2 tome el valor de o1, se le asigna una nueva dirección a la cual apuntar.