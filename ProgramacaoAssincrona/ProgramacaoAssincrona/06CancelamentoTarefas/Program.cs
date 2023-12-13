using System.Diagnostics;
namespace _06CancelamentoTarefas;
public class Program
{
    private static CancellationTokenSource? cancellationTokenSource;
    //permite ponto de entrada assincrono
    static async Task Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        try
        {
            //cancellationTokenSource = new CancellationTokenSource();
            //cancellationTokenSource?.Cancel();
            //Console.WriteLine("Cancelamento automatico após 1,5 segundos");
            //await ExecutaCancelamentoComTimeout(3000)
            Console.WriteLine("Cancelamento manual");
            await ExecutaCancelamentoManual();

            //Console.WriteLine(resultado);
        }
        catch (Exception)
        {
            Console.WriteLine($"Tarefa cancelada: " +
         $"tempo expirado após {stopwatch.Elapsed}.\n");
        }
        Console.ReadKey();
    }

    public static async Task ExecutaCancelamentoManual()
    {
        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            var TecladoTask = Task.Run(() =>
            {
                Console.WriteLine("Pressione algo para Cancelar…");
                Console.ReadKey();
                cancellationTokenSource.Cancel();
            });
            try
            {
                var tarefa = OperacaoLongaDuracaoCancelavel(500, cancellationTokenSource.Token);
                var resultado = await tarefa;
                Console.WriteLine($"Resultado {resultado}");
            }
            catch (TaskCanceledException)
            {
                throw;
            }
            await TecladoTask;
        }
    }
    public static async Task ExecutaTaskCancelamentoAsync()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource?.Cancel();

        Console.WriteLine($"Executou : {nameof(ExecutaTaskAsync)}");

        Console.WriteLine("Resultado {0}", await OperacaoLongaDuracaoCancelavel(100,
                                             cancellationTokenSource.Token));

        Console.WriteLine("Tempo gasto..." + stopwatch.Elapsed + "\n");
    }

    public static async Task ExecutaTaskAsync()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine($"Executou : {nameof(ExecutaTaskAsync)}");
        Console.WriteLine("Resultado {0}", await OperacaoLongaDuracao(100));
        Console.WriteLine("Tempo gasto..." + stopwatch.Elapsed + "\n");
    }
    private static Task<int> OperacaoLongaDuracaoCancelavel(int valor,
        CancellationToken cancellationToken = default)
    {
        Task<int> task = null;

        task = Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                // Verifica se foi solicitado o cancelamento
                // se foi lança um TaskCanceledException.
                if (cancellationToken.IsCancellationRequested)
                    throw new TaskCanceledException(task);

                Thread.Sleep(10);
                resultado += i;
            }
            return resultado;
        });
        return task;
    }

    private static Task<int> OperacaoLongaDuracao(int valor)
    {
        // inicia a tarefa e retorna
        return Task.Run(() =>
        {
            int resultado = 0;
            // Itera no laço for
            for (int i = 0; i < valor; i++)
            {
                // gasta o tempo 
                Thread.Sleep(50);
                resultado += i;
            }
            return resultado;
        });
    }
    public static async Task ExecutaCancelamentoComTimeout(int tempo)
    {   // Da pra assar no CacellationTokenSource o timeout pra cancelar.
        using (var cancellationTokenSource = new CancellationTokenSource())
        {
            cancellationTokenSource.CancelAfter(tempo);
            try
            {
                var resultado = await OperacaoLongaDuracaoCancelavel(100,
                    cancellationTokenSource.Token);

                Console.WriteLine($"Resultado {resultado}");
            }
            catch (TaskCanceledException)
            {
                throw;
            }
        }
    }
   
}