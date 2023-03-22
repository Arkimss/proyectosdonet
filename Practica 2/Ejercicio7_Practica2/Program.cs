// See https://aka.ms/new-console-template for more information
//¿Qué líneas producen error de compilación y por qué?
char c;
char? c2;
string? st;
c = "";// no se puede convertir implicitamente una variable de tipo char a una de tipo string
c = '';// no se le puede asignar un valor vacio 
c = null;// la variable c no admite el valor null, ya que no se declaró con un ? luego del char
c2 = null;
c2 = (65 as char?);
st = "";
st = ''; // la variable se debe inicializar correctamente agregando un caracter entre las comillas simples, de igual modo no existe la conversión implicita entre variables char a strings
st = null;
st = (char)65;// no existe conversión explicita integer = char, se debe utiliza el metodo parse
st = (string)65;// no existe conversión explicita integer = string, se debe utiliza el metodo parse
st = 47.89.ToString();