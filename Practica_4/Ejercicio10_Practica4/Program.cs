class A
    {
    public void Metodo(short n)
    {
        Console.Write("short {0} - ", n);
    }
    public void Metodo(int n)
    {
        Console.Write("int {0} - ", n);
    }
    public int Metodo(int n)
    {
        return n + 10;// se hizo un mal uso de la sobrecarga al hacer 2 metodos con los mismos parametros y el mismo nombre 
    }
