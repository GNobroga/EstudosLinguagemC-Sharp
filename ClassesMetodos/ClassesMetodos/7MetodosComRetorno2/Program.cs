Console.WriteLine("## Assinatura de método - Sobrecarga  ##\n");

Email email = new();

email.Enviar("empresa.com.br");
email.Enviar("empresa.com.br","Proposta comercial");
email.Enviar("empresa.com.br", 2000);
email.Enviar(200, "empresa.com.br");


Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereco )
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }

}

