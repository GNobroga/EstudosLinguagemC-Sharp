
using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();
//await ExecutaTarefaAsync(stopwatch);

var dadosTask = ExtrairDadosAsync();
var resultadoTask = InserirDadosAsync();

await Task.WhenAll(dadosTask, resultadoTask);
stopwatch.Stop();
Console.WriteLine("Tempo gasto : " + stopwatch.Elapsed.TotalSeconds);

var dados = await dadosTask;
var resultado = await resultadoTask;

Console.WriteLine("Resultado de Extrair dados = " + dados);
Console.WriteLine("Resultado de Extrair dados = " + resultado);

Console.ReadKey();
static async Task<string> ExtrairDadosAsync()
{
    Console.WriteLine("Extraindo dados...");
    string dados = "dados...";
    await Task.Delay(TimeSpan.FromMilliseconds(1500));
    return dados;
}
static async Task<bool> InserirDadosAsync()
{
    Console.WriteLine("Inserindo dados...");
    var resultado = true;
    await Task.Delay(TimeSpan.FromMilliseconds(2500));
    return resultado;
}

static async Task ExecutaTarefaAsync(Stopwatch stopwatch)
{
    var dados = await ExtrairDadosAsync();
    var resultado = await InserirDadosAsync();
    stopwatch.Stop();

    Console.WriteLine("\nTempo gasto : " + stopwatch.Elapsed.TotalSeconds);
}