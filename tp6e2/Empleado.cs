public class Empleado
{
    
    string nombre, apellido;
    DateTime fechaNacimiento, fechaIngreso;
    char estadoCivil, genero;
    double sueldo;
    Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, char estadoCivil, char genero, double sueldo, Cargos cargo) 
    {
        nombre = nombre;
    }
    public int antiguedad() 
    {
        return DateTime.Now - fechaIngreso;
    }
}