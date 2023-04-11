using Ejercicio7_Practica4;

Nodo Arbol = new Nodo(1);// el arbol no puede estar vacio.
Arbol.Insertar(1);
Arbol.Insertar(12);
Arbol.Insertar(9);
Arbol.Insertar(4);
Arbol.imprimir();
List<int> l = Arbol.InOrden();
Arbol.impLista(l);
//Console.WriteLine(Arbol.cantNodos());