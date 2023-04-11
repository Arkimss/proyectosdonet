namespace Ejercicio4_Practica4;
class Hora
{
    int _hora;
    int _minutos;
    int _segundos;
    public Hora(int hora, int minutos, int segundos)
    {
        _hora = hora;
        _minutos = minutos;
        _segundos = segundos;
    }
    public Hora(double f)
    {
        _hora = Convert.ToInt32(f);
        _minutos = (f - _hora) * 60;
        _segundos = (f - (_hora + _minutos)) * 60;
    }
    public string imp()
    {
        return $"{this._hora} horas, {this._minutos} minutos y {_segundos:0.000} segundos ";
    }
}