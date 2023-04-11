string st;
string? st1 = null;
string? st2 = null;
string? st3 = null;
string? st4 = null;
if (st1 == null)
{
    if (st2 == null)
    {
        st = st3;
    }
    else
    {
        st = st2;
    }
}
else
{
    st = st1;
}
if (st4 == null)
{
    st4 = "valor por defecto";
}
try
{
    Console.WriteLine(st);
}
catch
{
    Console.WriteLine("Null");
}
st = st1 ?? st2 ?? st3 ?? st2 ?? st1 ?? st4 ?? "Valor Por Defecto";
try
{
    Console.WriteLine(st);
}
catch
{
    Console.WriteLine("Null");
}