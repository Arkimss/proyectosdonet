namespace Ejercicio7_Practica4;
class Nodo
{
    Nodo? HD;
    Nodo? HI;
    int dato;

    public Nodo(int valor)
    {
        dato = valor;
        HD = null;
        HI = null;
    }

    public void Insertar(int valor)// si el numero es distinto, pregunta si es mayor que el valor de la raiz del arbol, si lo es, pregunta si el HD es null, si lo es, crea el hijo derecho y le asigna un valor, sino, va a insertar al hijo derecho, del HD, actua de igual manera con los HI.
    {

        if (valor != this.dato)
        {
            if (valor > this.dato)
            {
                if (HD == null)
                {
                    HD = new Nodo(valor);
                }
                else
                {
                    this.HD.Insertar(valor);
                }
            }
            else
                if (HI == null)
            {
                HI = new Nodo(valor);
            }
            else
            {
                HI.Insertar(valor);
            }
        }

    }
    public void imprimir()
    {
        Console.WriteLine(this.dato);
        if (HI != null)
            HI.imprimir();
        if (HD != null)
        {
            HD.imprimir();
        }
    }
    public void cargar(ref List<int> l)
    {
        if (HI != null)
        {
            HI.cargar(ref l);
            l.Add(this.dato);
        }
        if (HD != null)
        {
            l.Add(this.dato);
            HD.cargar(ref l);

        }
        if (HD == null && HI == null)
        {
            l.Add(this.dato);
        }
        //return l;
    }
    public List<int> InOrden()
    {
        List<int> aux = new List<int>();
        this.cargar(ref aux);
        return aux;
    }
    public void impLista(List<int> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            Console.WriteLine(" Elemento " + i + " " + l[i]);
        }
    }
    public int Cant(ref int n)
    {
        if (HI != null)
        {
            return HI.cantN() + 1;
        }
        if (HD != null)
        {
            return HD.cantNodos() + 1;

        }
        if (HD == null && HI == null)
        {
        }
    }
    public int GetCantNodos()
    {
        int n = 1;
        this.Cant(ref n);
        return n;
    }
    /* 
    public int cantNodos()
    {
        }
    } */
}

