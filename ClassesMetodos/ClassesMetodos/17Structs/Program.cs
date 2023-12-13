Console.WriteLine("## Structs ##\n");

Cliente cliente = new();
cliente.Nome = "Maria";
cliente.Idade = 19;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}