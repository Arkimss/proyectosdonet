class A
{
    private static int a; //campo estatico de la clase L/E
    private static readonly int b;// campo estatico de la clase de solo lectura
    A() { }//Constructor privado(?)
    public A(int i) : this() { }//constructor que invoca a otro constructor, pero no asigna a nda el parametro 
    static A() => b = 2; //Constructor estatico que le asigna a la variable de solo lectura un valor.
    int c; //variable de instancia privada. de lec/esc
    public static void A1() => a = 1; //metodo estatico que le asigna a una variable estatica un valor.
    public int A1(int a) => A.a + a;//  metodo de instancia que retorna la suma de un parametro con el campo estatico "a"
    public static int A2; // campo estatico publico. L/E
    static int A3 => 3; //   propiedad auto-implementada que retorna 3. 
    private int A4() => 4; //metodo privado que siempre retorna 4
    public int A5 { get => 5; }//propiedad que siempre retorna 5
    int A6 { set => c = value; }//propiedad privada de solo escritura que le asigna un valor entero a una variable privada c. 
    public int A7 { get; set; }// campo publico entero que cuenta con las propiedades auto-implementadas get y set.
    public int A8 { get; } = 8;// campo  entero publico que cuenta con una propiedad de solo lectura auto implementada inicializada con 8 y al no ser de escritura el get siempre retorna 8.
    public int this[int i] => i; // indizador que retorna un entero pasado por parametro.
}