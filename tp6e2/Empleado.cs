public class Empleado
{
    
    string nombre, apellido;
    DateTime fechaNacimiento, fechaIngreso;
    char estadoCivil, genero;
    double sueldo;
    Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
   
    public int antiguedad() 
    {
        return Convert.ToInt32((DateTime.Now - fechaIngreso).Days/365.2425);
    }

    public int edad()
    {
        return Convert.ToInt32((DateTime.Now - fechaNacimiento).Days/365.2425);
    }
    
}