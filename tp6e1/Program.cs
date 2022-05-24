
Calculadora calc = new Calculadora(5);

int op;
double a, b, r;
do {
    Console.WriteLine("\nIngrese el código de la operación: (0-4 u otra para salir)");
    op = Convert.ToInt16(Console.ReadLine());
    if(op>4)
        break;
    Console.WriteLine("Ingrese el operador: ");
    b = Convert.ToDouble(Console.ReadLine());
    if(op == 0)
        calc.Suma(b);
    if(op == 1)
        calc.Resta(b);
    if(op == 2)
        calc.Multiplicacion(b);
    if(op == 3)
        calc.Division(b);
    if(op == 4)
        calc.Limpiar();
    Console.WriteLine("\nEl resultado es " + calc.Resultado);
    } while (op<=4);

