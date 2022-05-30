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
    public int aniosParaJubilarse()
    {
        int anios = (char.ToUpper(genero) == 'M') ? 65 : 60; //falta control generos no binarios?
        return anios - edad();
    }
    // i) 1 % del sueldo básico por cada año de antigüedad hasta los
    // 20 años, a partir de este, el porcentaje se fija en 25%.
    // ii) Si el cargo es Ingeniero o Especialista, el Adicional se
    // incrementa en un 50%.
    // iii) Si es casado al Adicional se le aumenta $15000.
    // Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
    // $65000, el Adicional es 65000 * 0.15 = 9750. Si además el cargo
    // es Ingeniero o Especialista, se incrementa el Adicional en un
    // 50%. Esto es: 9750* 1.50 = 14625. Si a su vez es casado el
    // Adicional será: 14625+ 15000= 29625
    public double salario() 
    {
        double total = sueldo;

        if(antiguedad()>20) {
            total += 0.25*sueldo;
        } else {
            total += 0.01*antiguedad()*sueldo;
        }
        if(cargo==Cargos.Ingeniero || cargo==Cargos.Especialista) {
            total += 0.5*sueldo;//0.5*total error de enunciado?
        }
        if(char.ToUpper(estadoCivil) == 'c') {
            total += 15000;
        }
        return total;
    }
}  