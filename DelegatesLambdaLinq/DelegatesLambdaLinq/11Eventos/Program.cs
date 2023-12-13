Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes em um evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();

Console.ReadKey();

class Pedido
{
    //criar o evento associado ao delegate
    public event EventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado !!!");

        if (OnCriarPedido != null)
        {
            OnCriarPedido(this,EventArgs.Empty);
        }
    }
}

class Email
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um email");
    }
}

class SMS
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}