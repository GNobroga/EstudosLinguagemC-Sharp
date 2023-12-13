namespace Novidades.c9;

/*
  E um tipo de referencia

  A comparacao em Record funciona como em tipos por valor.

  Ele suporta herenca e destruturacao.

  O tipo record e imutavel.

  Palavra chave With, permite criar um objeto apartir de outro
  existente alterando apenas algumas propriedades.

*/

public record Cliente
{
  public string Nome;
  public int Idade;

  public Cliente(string nome, int idade)
  {
    Nome = nome;
    Idade = idade;
  }

  // Criando um Deconstructor para permitir destruturar, Funciona em classe tambem.
  public void Deconstruct(out string nome, out int idade)
  {
    nome = Nome;
    idade = Idade;
  }
}

// Sintaxe Positional Record
// Com essa sintaxe ele ja cria tudo, inclusive o Deconstruct
public record Ator(string Nome, int Idade);

// Heranca

public record Pessoa : Ator
{
  public Pessoa(string nome, int idade) : base(nome, idade)
  {}
}
