namespace Ejercicio7_Practica5;




public class Persona
{
    char? _Sexo;
    int? _DNI;
    string? _Nom;
    DateTime _FechaDeNacimiento {get; set;}

    public Persona(string nom, char sexo, int dni, DateTime fn)
    {
        _Sexo = sexo;
        _Nom = nom;
        _DNI = dni;
        _FechaDeNacimiento = fn;
    }
    public int edad
    {
        get
        {
            DateTime d = DateTime.Now;
            if (d.Month > _FechaDeNacimiento.Month)
                return (d.Year - _FechaDeNacimiento.Year) - 1;
            else
                return d.Year - _FechaDeNacimiento.Year;
        }
    }
    public object? this[int i]
    {
        get
        {
            if (i == 0) return _Nom;
            else if (i == 1) return _Sexo;
            else if (i == 2) return _DNI;
            else if (i == 3) return _FechaDeNacimiento;
            else if (i == 4) return edad;
            else return null;
        }
        set
        {
            if (i == 0) _Nom = (string?)value;
            else if (i == 1) _Sexo = (char?)value;
            else if (i == 2) _DNI = (int?)value;
            else if (i == 3) _FechaDeNacimiento = (DateTime)value;
        }
    }
    /*Nombre de tipo
    string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. Además
    definir una propiedad de sólo lectura (calculada) Edad de tipo int. Definir un indizador de
    lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
    objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
    nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
    que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string.*/




}