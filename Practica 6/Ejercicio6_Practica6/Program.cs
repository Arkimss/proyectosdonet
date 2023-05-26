

/*
 6.1 El error de este codigo es que la clase base A, no hace que su metodo M1 sea virtual, por lo que no puede ser invalidado por su clase derivada.
class A
{
public string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";

6.2 El error de este codigo es que la clase A no esta declarada como abstracta.
class A
{
public abstract string M1();
}
class B : A
{
public override string M1()
=> "B.M1";
}

6.3

abstract class A El metodo M1 no debe ser implementado en la clase abstracta, sino en sus derivadas.
{
public abstract string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";
}
} 

  6.4 El override deberia reemplazarse por un virtual, ya que el metodo de la clase base no debe invalidarse

  class A
{
public override string M1()
=> "A.M1";
}
class B : A
{
public override string M1()
=> "B.M1";
}

6.5 El error de este codigo es que al invalidar el metodo M1 se le pone protected al modificador de acceso del metodo, el modificador de acceso del metodo de la clase base no puede modificarse


class A
{
public virtual string M1()
=> "A.M1";
}
class B : A
{
protected override string M1()
=> "B.M1";
}



*/