Console.WriteLine("## Classes e Objetos ##\n");

Pessoa p1 = new();

p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");


Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}