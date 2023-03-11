
Console.WriteLine("Ingrese 2 cadenas de caracteres");
string st = Console.ReadLine();
int i = 0;// variable indice para recorrer los caracteres del primer string del primero al último
          //int ind2 = st2.Length - 1;// variable indice para recorrer los caracteres del segundo string, del último al primero
bool cond = true;
while ((cond) && (i < st.Length - (i + 1)))
{
    if (st[i] == st[st.Length - (i + 1)])
        i++;
    else
        cond = false;
}
Console.WriteLine(cond);
Console.ReadKey(true);






/*
       if (st[ind] != st2[ind2])
       {
           cond = false;
           break;
       }
       ind++;
       ind2--;
   }
   if (cond)
       Console.WriteLine(" Las cadenas son simetricas ");
   else
       Console.WriteLine("Las cadenas no son simetricas");
}
else
   Console.WriteLine("las cadenas no son simetricas");
Console.ReadKey(true);*/

