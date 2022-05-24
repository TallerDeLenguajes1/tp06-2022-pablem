
public class Calculadora
{

    public double Resultado;
    
    public Calculadora(double valorInicial)
    {
        Resultado = valorInicial;
    }
    public void Suma(double valor)
    {
        Resultado += valor;
    }
    public void Resta(double valor)
    {
        Resultado -= valor; 
    }public void Multiplicacion(double valor)
    {
        Resultado *= valor; 
    }
    public void Division(double valor)
    {
        Resultado /= valor; 
    }
    public void Limpiar()
    {
        Resultado = 0;
    }

}