
Console.WriteLine("Acessar arquivo poesia.txt na pasta d:\\dados");
Console.WriteLine("Informe o caminho e nome do arquivo");

string? caminhoArquivo = Console.ReadLine();

AcessarArquivo(caminhoArquivo);

Console.ReadKey();
static void AcessarArquivo(string? caminhoArquivo)
{
    StreamReader? leitor = null;
    try
	{
        leitor = File.OpenText(caminhoArquivo);
        Console.WriteLine("");
        Console.WriteLine(leitor?.ReadToEnd());
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("\nArquivo não encontrado: " + ex.Message);
    }
    catch (UnauthorizedAccessException ex)
    {
        Console.WriteLine("Erro: Acesso não autorizado ao arquivo: " + caminhoArquivo);
        Console.WriteLine("Exceção : " + ex.Message);
    }
	catch (Exception ex)
	{
        Console.WriteLine("\nOcorreu um erro : " + ex.Message);
    }
    finally
    {
        if(leitor is not null)
        {
            leitor.Close();
        }
        Console.WriteLine("\nBloco finally executado");
    }
}

