using Ejercicio8_Practica5;
DateTime d = new DateTime(2020, 03, 4, 10, 30, 55);
Persona p = new Persona("Juan", 'F', 409995, d);
ListaDePersonas l = new ListaDePersonas(p);
DateTime d1 = new DateTime(2021, 03, 4, 10, 30, 55);
Persona p1 = new Persona("Braian", 'F', 41999555, d);
l.Agregar(p1);
DateTime d2 = new DateTime(2022, 03, 4, 10, 30, 55);
Persona p2 = new Persona("Acosta", 'M', 42999555, d);
l.Agregar(p2);
DateTime d3 = new DateTime(2023, 03, 4, 10, 30, 55);
Persona p3 = new Persona("Ale", 'M', 43999555, d);
l.Agregar(p3);
DateTime d4 = new DateTime(2019, 03, 4, 10, 30, 55);
Persona p4 = new Persona("Astrid", 'F', 44999525, d);
l.Agregar(p4);

List<string> nombres = l['J'];
foreach (string st in nombres)
{
    Console.WriteLine(st);
}




