class Persona
{
    public string Nombre { get; set; }
}
public class Auto
{
    private Persona? _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1; // tira un error de compilación porque en las propiedades, siempre el modificador de acceso  de la propiedad tiene que ser mas restrictivo que la variable de instancia a retornar/modificar, en este caso el modificador de acceso de la variable  _dueño1 es más restrictivo que el modificador de acceso de la propiedad 
    protected Persona SegundoDueño // tira un error de compilación porque en las propiedades, siempre el modificador de acceso  de la propiedad tiene que ser mas restrictivo que la variable de instancia a retornar/modificar, en este caso el modificadoor de acceso de la variable _dueño2 es mas restrictivo que el de la propiedad
    {
        set => _dueño2 = value;
    }
}