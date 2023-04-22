using Ejercicio1_Practica6;

A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{// if (a is B h)
    if (a.GetType() == typeof(B))
        a.Imprimir();
}
foreach (A a in vector)
{// if (a is B h)
    if ((a is B) && (a is not C) && (a is not D))
        a.Imprimir();
}