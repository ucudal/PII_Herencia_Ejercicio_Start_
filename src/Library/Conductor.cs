namespace ClassLibrary;

public class Conductor   
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Cedula {get; set;}
    public string Vehiculo {get; set;}
    public int Calificacion {get; set;}
    public string Biografia {get; set;}
    public Conductor(string nombre, string apellido, string cedula, string vehiculo, int calificacion, string biografia)
    {
        Nombre = nombre;
        Apellido = apellido;
        Cedula = cedula;
        Vehiculo = vehiculo;
        Calificacion = calificacion;
        Biografia = biografia;
    }
}