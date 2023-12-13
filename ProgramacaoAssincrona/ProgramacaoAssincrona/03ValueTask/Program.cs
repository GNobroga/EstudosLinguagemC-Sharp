
Console.WriteLine("\nIniciando a operação assíncrona...");


await MetodoSemRetornoAsync();

Console.WriteLine("\nIniciando a operação assíncrona...");

var TarefaResultado = MetodoRetornaValorAsync(20);
var resultado = await TarefaResultado;
Console.WriteLine($"Resultado: {resultado}");


Console.ReadKey();

static async ValueTask MetodoSemRetornoAsync()
{
    Console.WriteLine("-Método que não retorna valor");
    await Task.Delay(2000);
}

static async ValueTask<int> MetodoRetornaValorAsync(int valor)
{
    Console.WriteLine("-Método que retorna valor");
    await Task.Delay(2000);
    return valor * 2;
}

