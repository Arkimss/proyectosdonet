char c1 = 'A';
string st1 = "A";
object o1 = c1; // boxing, se le asigna una variable de tipo de valor a una de tipo referencia 
object o2 = st1;//nada, ambos son de referencias
char c2 = (char)o1;//unboxing, a una variable de referencias se le asigna una de tipo valor
string st2 = (string)o2;//nada
