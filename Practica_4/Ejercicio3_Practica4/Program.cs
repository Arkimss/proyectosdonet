using Practica_4;

Persona[] p = new Persona[];
for (int i = 0; i < 4; i++)
{
    p[i] = new Persona(17 + i, 45569520 + i, "Acosta" + i);
}
Persona PersonaMin = new Persona(999, 0, " ");
for (int i = 0; i < p.Length; i++)
{
    if (p[i].EsMayorQue(PersonaMin))
    {
        PersonaMin = p[i];
    }
}
Console.WriteLine($"La Persona mas joven es: {PersonaMin.toString()} ");