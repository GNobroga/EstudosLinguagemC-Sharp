var aluno = new
{
    Nome = "Maria",
    Idade = 42
};
Console.WriteLine(aluno.Nome + " - " + aluno.Idade + " anos");

Console.ReadKey();

var aluno1 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@email.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

Console.WriteLine($"Nome: {aluno1.Nome}");
Console.WriteLine($"Endereço:  {aluno1.Endereco.Cidade}");

Console.ReadKey();

var alunos = new[] {
             new { Id = 1, Nome = "Maria", Email = "maria@email.com" },
             new { Id = 2, Nome = "Sonia", Email = "sonia@email.com" },
             new { Id = 3, Nome = "Bruno", Email = "bruno@email.com" }
           };

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);

Console.ReadKey();
