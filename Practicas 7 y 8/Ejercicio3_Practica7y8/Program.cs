using Ejercicio3_Practica7y8;

var lista = new List<object>() {
new Persona(),
new Autos()
};
foreach (IComercial c in lista)
{
    c.Importa();
}
foreach (IImportante i in lista)
{
    i.Importa();
}
(lista[0] as Persona)?.Importa();
(lista[1] as Autos)?.Importa();