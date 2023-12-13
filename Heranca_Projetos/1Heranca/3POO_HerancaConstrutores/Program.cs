
var aluno = new Aluno("Jose");

Console.ReadKey();


class Pessoa
{
    public Pessoa(string nome)
    {
        Console.WriteLine("construtor da classe Pessoa com parametro");
    }
}

class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("construtor da classe Aluno");
    }
}