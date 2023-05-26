Action[] acciones = new Action[10];
for (int i = 0; i < 10; i++)
{
acciones[i] = () => Console.WriteLine(i + " ");
}
foreach (var a in acciones)
{
a.Invoke();
}
//Imprime 10 veces 10, por lo que toma una referencia de la variable a utilizar