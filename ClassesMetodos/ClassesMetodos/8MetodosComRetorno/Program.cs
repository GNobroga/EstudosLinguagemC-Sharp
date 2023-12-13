Console.WriteLine("## Métodos  ##\n");

Cadastro cadastro = new();
var cliente  = cadastro.Registrar();
cadastro.ExibirDados(cliente);

//alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente()
    { }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto,Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.Write($" {cliente.Nome} {cliente.Renda.ToString("c")}");
    }
}