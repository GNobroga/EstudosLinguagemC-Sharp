/*
  Operador: init

  Ele torna as propriedades como sendo imutaveis.

  Nao e obrigado a inicializar essa variavel, porem, ela vai
  permanecer com seu valor padrao.

*/
class Pessoa 
{
  public string Nome { get; init; }


  // E permitido fazer validacoes.
  public string LastName { 
    get => "dsds"; 
    init {
    if (value.Length > 2) 
    {
      Nome = value;
    }
  }}
}