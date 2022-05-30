// See https://aka.ms/new-console-template for more information

Empleado emp1 = new Empleado();
emp1.Nombre = "nombre01";
emp1.Apellido = "apellido01";
emp1.FechaNacimiento = new DateTime(2001,1,1);
emp1.FechaIngreso = new DateTime(2020,1,1);
emp1.EstadoCivil = 'c';
emp1.Genero = 'f';
emp1.Sueldo = 10000;
emp1.Cargo = Cargos.Auxiliar;

Empleado emp2 = new Empleado();
emp2.Nombre = "nombre02";
emp2.Apellido = "apellido02";
emp2.FechaNacimiento = new DateTime(1091,1,1);
emp2.FechaIngreso = new DateTime(2022,1,1);
emp2.EstadoCivil = 's';
emp2.Genero = 'm';
emp2.Sueldo = 10000;
emp2.Cargo = Cargos.Administrativo;

Empleado emp3 = new Empleado();
Console.WriteLine("+ Empleado 3. Nombre: ");
emp3.Nombre = Console.ReadLine();
Console.WriteLine("Apellido: ");
emp3.Apellido = Console.ReadLine();
Console.WriteLine("Fecha de nacimiento: ");
// int d = Console.Read();
// int m = Console.Read();
// int a = Console.Read();
// emp3.FechaNacimiento = new DateTime(a,m,d);
// Console.WriteLine("Fecha de Ingreso: ");
// d = Console.Read();
// m = Console.Read();
// a = Console.Read();
// emp3.FechaIngreso = new DateTime(a,m,d);
Console.WriteLine("Estado civil: ");
emp3.EstadoCivil = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Género: ");
emp3.Genero = Convert.ToChar(Console.ReadLine());
Console.Write("Sueldo básico: ");
emp3.Sueldo = Convert.ToDouble(Console.ReadLine());
Console.Write("Cargo: ");
emp3.Cargo = (Cargos) Convert.ToInt16(Console.ReadLine());

Console.WriteLine(emp3.Cargo);