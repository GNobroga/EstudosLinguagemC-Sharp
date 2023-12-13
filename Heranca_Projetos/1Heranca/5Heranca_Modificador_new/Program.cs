/*
    Eu posso usar o modificar new no metodo de uma classe para
    indicar que aquele metodo foi sobrescrito.

*/
Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }

    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public new string Saudacao()
        => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}.";
}