await LancaMultiplasExcecoesAsync();
Console.ReadKey();
static async Task LancaMultiplasExcecoesAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() => {
            Task.Delay(1000);
            throw new IndexOutOfRangeException
            ("IndexOutOfRangeException lançada explicitamente.");
        });
        var segundaTask = Task.Run(() => {
            Task.Delay(1000);
            throw new InvalidOperationException
            ("InvalidOperationException lançada explicitamente");
        });

        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções :-\n");
        AggregateException TodasExceptions = tarefas.Exception;

        foreach (var ex in TodasExceptions.InnerExceptions)
        {
            Console.WriteLine(ex.GetType().ToString() + "\n\n" + ex.Message);
        }
    }
}

static async void CapturaApenasUmaException()
{
    await LancaMultiplasExcecoesAsync();

    Console.ReadKey();
    static async Task LancaMultiplasExcecoesAsync()
    {
        try
        {
            var primeiraTask = Task.Run(() => {
                Task.Delay(1000);
                throw new IndexOutOfRangeException
                ("IndexOutOfRangeException lançada explicitamente.");
            });
            var segundaTask = Task.Run(() => {
                Task.Delay(1000);
                throw new InvalidOperationException
                ("InvalidOperationException lançada explicitamente");
            });
            await Task.WhenAll(primeiraTask, segundaTask);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}