namespace Ejercicio8_Practica5;

public class ListaDePersonas
{
    List<Persona> l;

    public ListaDePersonas(Persona P)
    {
        l = new List<Persona>() { P };

    }

    public void Agregar(Persona p)
    {
        l.Add(p);
    }

    public Persona? this[int DNI]
    {
        get
        {
            int i = 0; bool ok = false;
            while ((i < l.Count) && (!ok))
            {
                if ((int)l[i][2] == DNI)
                {
                    ok = true;
                }
                i++;
            }
            if (ok)
            {
                return l[i];
            }
            else
                return null;
        }
    }
    public List<string> this[char c]
    {
        get
        {
            string st;
            List<string> aux = new List<string>();
            for (int i = 0; i < l.Count; i++)
            {
                st = (string)l[i][0];// paso el nombre a una variable para que sea mas legible
                if (st[0] == c)
                    aux.Add(st);
            }
            return aux;
        }
    }


}