Console.WriteLine("\nUsando o evento OnCriarPedido com EventHandler<TEventArgs> ");
var pedido = new Pedido();

//inscrever os assinantes em um evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("maria@email.com", "(11) 9854-5588");

Console.ReadKey();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}
class Pedido
{
    //criar o evento associado ao delegate
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;
    public void CriarPedido(string email, string fone)
    {
        Console.WriteLine("\nPedido criado !!!");

        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email=email, Telefone=fone});
        }
    }
}
class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {

        Console.WriteLine($"\nEnviando um email para : {e.Email}");
    }
}
class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um SMS para : {e.Telefone}");
    }
}
