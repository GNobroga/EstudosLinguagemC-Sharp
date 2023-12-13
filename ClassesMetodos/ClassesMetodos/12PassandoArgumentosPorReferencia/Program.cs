Console.WriteLine("## Passando argumentos por referência ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new();
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2; //y=y*2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}

