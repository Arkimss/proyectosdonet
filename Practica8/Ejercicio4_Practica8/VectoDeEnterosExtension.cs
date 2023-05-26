static class VectorDeEnterosExtension
{
public static void Print(this int[] vector, string leyenda)
{
string st = leyenda;
if (vector.Length > 0)
{
foreach (int n in vector) st += n + ", ";
st = st.Substring(0, st.Length - 2);
}
Console.WriteLine(st);
}
public static int[] Seleccionar(this int[] v, FuncionEntera f )
{
  int[] aux = new int[v.Length];
  for (int i = 0; i < v.Length; i++)
  {
    aux[i] = f(v[i]);
  }

  return aux;
}


}
