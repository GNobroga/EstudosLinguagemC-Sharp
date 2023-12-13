namespace _15Composicao;

internal class Instalador
{
    public string? Local { get; set; }
    public DateTime DataHora { get; set; }

    private readonly Logger _logger;
    public Instalador(Logger logger)
    {
        _logger= logger;
    }
    public void Instalar(string mensagem)
    {
       _logger.Log($"{mensagem} - instalando em: {Local} em : {DataHora}");
    }
}
