await LancaExceptionAsync();

Console.ReadKey();

static async Task LancaExceptionAsync()
{
    try
    {
        var primeiraTask = Task.Run(() => {
            Task.Delay(1000);
            throw new IndexOutOfRangeException
            ("IndexOutOfRangeException lançada explicitamente.");
        });
        await primeiraTask;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bloco catch executado");
        Console.WriteLine(ex.Message);
    }
}
class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() => {
            Task.Delay(2000);
            throw new Exception("Minha Exception...");
        });
    }
    public async void ChamaTarefaAsync()
    {
        await MinhaTarefaAsync();
    }
}