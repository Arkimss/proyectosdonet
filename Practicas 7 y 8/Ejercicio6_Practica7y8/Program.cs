using Ejercicio6_Practica7y8;

var vector = new INombrable[] {
new Persona() {Nombre="Ana María"},
new Perro() {Nombre="Sultán"},
new Persona() {Nombre="Ana"},
new Persona() {Nombre="José Carlos"},
new Perro() {Nombre="Chopper"}
};
Array.Sort(vector, new ComparadorLongitudNombre());//ordena por longitud de Nombre
foreach (INombrable n in vector)
{
    Console.WriteLine($"{n.Nombre.Length}: {n.Nombre}");
}