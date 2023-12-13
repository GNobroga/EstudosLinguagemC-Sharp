Console.WriteLine("## Métodos com Retorno  ##\n");

Calculadora calc = new();

var valor = calc.Somar(10, 10);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(10, 10));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
