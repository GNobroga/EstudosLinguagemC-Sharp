using Macoratti.Teste;

Aluno aluno = new Aluno();
Curso curso = new Curso();

Macoratti.Curso.Aluno.Exibir();

Console.ReadKey();

namespace Macoratti.Teste
{
    public class Aluno 
    {}
    public class Curso 
    {}
}
namespace Macoratti.Curso
{
    public class Aluno
    { 
        public static void Exibir()
        {
            Console.WriteLine("Método Exibir - classe Demo.Aluno");
        }
    }
}
