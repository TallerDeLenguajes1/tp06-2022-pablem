//IMPLEMENTACIÓN CON LISTA:
// var emp = new List<Empleado>();
// Empleado nuevo; 
// for (int i = 0; i < 3; i++) {
//     nuevo = new Empleado();

//     emp.Add(nuevo);
// }

Empleado emp1 = new Empleado();
emp1.Nombre = "nombre01";
emp1.Apellido = "apellido01";
emp1.FechaNacimiento = new DateTime(2001,1,1);
emp1.FechaIngreso = new DateTime(2020,1,1);
emp1.EstadoCivil = 's';
emp1.Genero = 'f';
emp1.Sueldo = 10000;
emp1.Cargo = Cargos.Auxiliar;

Empleado emp2 = new Empleado();
emp2.Nombre = "nombre02";
emp2.Apellido = "apellido02";
emp2.FechaNacimiento = new DateTime(1992,1,1);
emp2.FechaIngreso = new DateTime(2020,1,1);
emp2.EstadoCivil = 'c';
emp2.Genero = 'f';
emp2.Sueldo = 10000;
emp2.Cargo = Cargos.Ingeniero;

//Empleado 3 se carga por consola
Empleado emp3 = new Empleado();
Console.WriteLine("+ Empleado 3. Nombre: ");
emp3.Nombre = Console.ReadLine();
Console.WriteLine("Apellido: ");
emp3.Apellido = Console.ReadLine();
Console.WriteLine("Fecha de nacimiento: (aaaa-mm-dd)");
emp3.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Fecha de Ingreso: (aaaa-mm-dd)");
emp3.FechaIngreso = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Estado civil: ");
emp3.EstadoCivil = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Género: ");
emp3.Genero = Convert.ToChar(Console.ReadLine());
Console.Write("Sueldo básico: ");
emp3.Sueldo = Convert.ToDouble(Console.ReadLine());
Console.Write("Cargo: ");
emp3.Cargo = (Cargos) Convert.ToInt16(Console.ReadLine());

var listaEmpleados = new List<Empleado>();
listaEmpleados.Add(emp1);
listaEmpleados.Add(emp2);
listaEmpleados.Add(emp3);

double total = 0;
foreach (var emp in listaEmpleados) {
    total += emp.salario();
}
Console.WriteLine("\nMonto total = "+total);

Empleado aux1 = listaEmpleados[0];
int aux2 = listaEmpleados[0].aniosParaJubilarse();
foreach (var emp in listaEmpleados) {
    if (emp.aniosParaJubilarse()<aux2) {
        aux1 = emp;
    }
    aux2 = emp.aniosParaJubilarse();
}
Console.WriteLine("\nEmpleado más proximo a jubilarse: "+aux1.Nombre+" "+aux1.Apellido);
Console.WriteLine("Fecha de nacimiento: "+aux1.FechaNacimiento.ToString("dd/MM/yyyy"));
Console.WriteLine("Estado civil: "+aux1.EstadoCivil);
Console.WriteLine("Género: "+aux1.Genero);
Console.WriteLine("Fecha de ingreso: "+aux1.FechaIngreso.ToString("dd/MM/yyyy"));
Console.WriteLine("Sueldo básico: "+aux1.Sueldo);
Console.WriteLine("Cargo: "+aux1.Cargo);

Console.WriteLine("\nAntigüedad: "+aux1.antiguedad()+" años");
Console.WriteLine("Edad: "+aux1.edad());
Console.WriteLine("Años para jubilarse: "+aux1.aniosParaJubilarse()+" años");
Console.WriteLine("Salario: "+aux1.salario());

