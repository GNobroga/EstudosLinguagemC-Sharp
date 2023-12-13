await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //criar um CancellationTokenSource
    var tempo = 20;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

    try
    {
        using var httpClient = new HttpClient();
        var destino = "d:\\dados\\arquivo.txt";

        var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);

        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fileStream = new FileStream(destino, FileMode.Create,
                                                             FileAccess.Write);

        await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

        var buffer = new byte[81920];
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length,
            cancellationTokenSource.Token)) > 0)
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
            readBytes += bytesRead;
            Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
        }
    }
    catch (OperationCanceledException ex)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado por tempo limite : " + ex.Message);
        }
        else
        {
            Console.WriteLine("\nO tempo limite para o download foi atingido.");
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("\nDownload finalizado.");
    }
}
