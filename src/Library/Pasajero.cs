namespace ClassLibrary;

public class Pasajero   
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Cedula {get; set;}
    public int Calificacion {get; set;}
    public Pasajero(string nombre, string apellido, string cedula, int calificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Cedula = cedula;
        Calificacion = calificacion;
    }
}