namespace _13Interfaces_Exercicio;

public interface ISalvar
{
    void Salvar();
    void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
