
using System.Net.Http.Json;

try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");
    Console.WriteLine("Informe o nome do arquivo.");
    string? arquivo = Console.ReadLine();
    Console.WriteLine("Informe a url do site.");
    string? url = Console.ReadLine();
    Console.WriteLine("\nAguarde...");

    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + "/"+ arquivo).Result;

    if(response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso");
        Console.WriteLine("Código de status : " + response.StatusCode);
    }
    else
    {
        throw new HttpRequestException("Erro : " + response.StatusCode);
    }
}
catch(HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine(" Erro : " + ex.Message);
}
finally
{
    Console.WriteLine("Processamento concluido");
}

Console.ReadKey();