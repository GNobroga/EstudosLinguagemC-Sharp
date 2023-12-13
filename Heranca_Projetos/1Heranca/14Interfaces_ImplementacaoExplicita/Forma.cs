namespace _14Interfaces_ImplementacaoExplicita;

public class Forma : IControle, IGrafico
{
    void IControle.Desenhar()
    {
        Console.WriteLine("Desenhando controle...");
    }

    void IGrafico.Desenhar()
    {
        Console.WriteLine("Desenhando gráfico...");
    }
}
