services.AddHttpClient("NomeDoCliente", c =>
{
    // Configurações do cliente, se necessário
    c.BaseAddress = new Uri("https://exemplo.com/");
});

private readonly IHttpClientFactory _httpClientFactory;

public MyClass(IHttpClientFactory httpClientFactory)
{
    _httpClientFactory = httpClientFactory;
}

public async Task FazerRequisicao()
{
    using (HttpClient client = _httpClientFactory.CreateClient("NomeDoCliente"))
    {
        // Use o HttpClient para fazer solicitações HTTP
    }
}
