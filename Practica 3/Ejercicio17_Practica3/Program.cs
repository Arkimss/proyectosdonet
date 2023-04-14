using System.Text;
Console.WriteLine("ingrese la operacion");
string st = Console.ReadLine();
StringBuilder op1s = new StringBuilder();// operando 1 string
StringBuilder op2s = new StringBuilder();// operando 2 string
int posOperador = 0;
for (int i = 0; i < st.Length; i++)
{
    if ((st[i] != '+') && (st[i] != '-') && (st[i] != '/') && (st[i] != '*'))
    {
        op1s.Append(st[i]);
    }
    else
    {
        posOperador = i;
    }
    if (posOperador != 0)
    {
        op2s.Append(st[i]);
    }
}

}
try
{
    int op1 = int.tryString(op1s);
    {

    }
    catch (System.Exception)
{

    throw;
};
}