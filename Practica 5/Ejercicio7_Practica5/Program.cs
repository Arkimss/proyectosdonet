using Ejercicio7_Practica5;
DateTime fecha = new DateTime(2010, 05, 05, 10, 30, 00);
Persona p = new Persona("Pedro", 'M', 45569520, fecha);
for (int i = 0; i < 4; i++)
{
    if (p[i] != null)
        Console.WriteLine(p[i]);
}
