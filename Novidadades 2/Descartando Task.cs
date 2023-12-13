class Program
{
    static async Task Main()
    {
        Console.WriteLine("Início do programa");

        // Ignora o resultado e fala pro compilador parar de reclamar
        _ = ExecutarOperacaoAsync(); // Ignorando o resultado da Task

        Console.WriteLine("Fim do programa");
     
    }

    static async Task<int> ExecutarOperacaoAsync()
    {
        Console.WriteLine("Início da operação assíncrona");

        // Simulação de operação assíncrona
        await Task.Delay(5000);

        Console.WriteLine("Fim da operação assíncrona");

        return 100;
    }
}
