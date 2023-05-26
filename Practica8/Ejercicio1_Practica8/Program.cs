int i = 10;
Action a = delegate ()
{
Console.WriteLine(i);
};
a.Invoke();
i = 20;
a.Invoke();
//Obtiene una copia del valor de la variable