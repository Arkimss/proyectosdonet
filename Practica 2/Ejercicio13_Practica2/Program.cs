
for (meses m = meses.diciembre; m >= meses.enero; m--)
{
    Console.WriteLine(m);
}
Console.WriteLine(" ingrese un texto");
string mes = Console.ReadLine();
bool es = false;
for (meses m = meses.enero; m <= meses.diciembre; m++)
{
    if (m.ToString() == mes)
    {
        es = true;
        break;//esta mal, pero no tan mal
    }

}
Console.WriteLine("Era mes: " + es);
Console.ReadKey(true);
enum meses
{
    enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre
}
