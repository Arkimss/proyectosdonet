namespace Ejercicio4_Practica9;

class ListaEnlazada<T> : IEnumerable
{
    Nodo<T>? _nodo;
    static int _cont = 0;

    public void AgregarAdelante(T dato)
    {
        Nodo<T> nue = new Nodo<T>(dato);
        if (_nodo != null)
            _nodo.Proximo = _nodo;
        _nodo = nue;
        _cont++;
    }
    //public void AgregarAtras(T dato)

    public IEnumerator<T> GetEnumerator()
    {
        var aux = _nodo;
        while (aux != null)
        {
            yield return aux.Valor;
            aux = aux.Proximo;
        }
    }
}