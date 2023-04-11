namespace Automotores;
public class Auto
{
    private string _marca;// declararlas sin modificador es como declararlas como privada
    private int _modelo;

    // constructores: me da la posibilidad de recibir datos para inicializar el objeto con datos
    // sobrecarga: si se repiten constructores, deben diferir en la cantidad de parametros //COMPLETAR
    // los tipos de los parametros
    // si hay un metodo que pide como parametro un int y el otro pide un object. Si se pasa como pàrametro un int va al metodo mas bajo en la jerarquia de tipos
    //En la sobre carga nunca se castea


    public Auto(string marca, int modelo)
    {
        _marca = marca;
        _modelo = modelo;
    }
    public Auto()
    {
        _marca = "Fiat";
        _modelo = DateTime.Now.Year;
    }
    //para invoccar un constructor dentro nde otro se debe usar :this
    public Auto(string marca) : this()           //invoca al constructor sin argumentos
    {
        _marca = marca;
    }
    public string GetDescripcion()
    {
        return $"Auto {_marca} {_modelo}";
    }
}
