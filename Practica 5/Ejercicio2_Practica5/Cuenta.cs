namespace Ejercicio2_Practica5;

public class Cuenta
{

    double _Saldo;
    public string _ID { get; }

    static double _TotalDepositado { get; set; } = 0;
    static double _TotalExtraido { get; set; } = 0;
    static int _Depositos { get; set; } = 0;
    static int _Extracciones { get; set; } = 0;
    static int _ExtraccionesDenegadas { get; set; } = 0;
    static int _CuentasCreadas { get; set; } = 0;
    public static List<Cuenta> GetCuentas()
    {
        return GetCuentas();
    }
    public Cuenta()
    {
        _CuentasCreadas++;
        _ID = $"{_CuentasCreadas}";
        Console.WriteLine($"Se creo la cuenta ID= {_ID}");
        _Saldo = 0;
        GetCuentas();
    }


    public Cuenta Depositar(double a)
    {
        _Saldo += a;
        Console.WriteLine($"Se depositó {a} en la cuenta ID= {_ID} (Saldo = {_Saldo}");
        _TotalDepositado += a;
        _Depositos++;
        return this;
    }

    public Cuenta Extraer(double v)
    {
        double aux = _Saldo - v;
        if (aux < 0)
        {
            Console.WriteLine("Operación denegada - Saldo insuficiente");
            _ExtraccionesDenegadas++;
        }
        else
        {
            _Saldo -= v;
            Console.WriteLine($"Se extrajo {v} de la cuenta {_ID} (Saldo= {_Saldo})");
            _TotalExtraido += v;
            _Extracciones++;
        }
        return this;
    }
    public static void Imprimir()
    {
        Console.WriteLine($"CUENTAS CREADAS: {_CuentasCreadas}");
        Console.WriteLine($"DEPÓSITOS: {_Depositos}      -Total depositado: {_TotalDepositado}");
        Console.WriteLine($"EXTRACCIONES:{_Extracciones} -Total Extraido: {_TotalExtraido} ");
        Console.WriteLine($"* se denegaron {_ExtraccionesDenegadas} por falta de fondos");

    }
}