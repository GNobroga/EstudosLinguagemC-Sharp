internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes = new string[5];
        double[] notas = new double[5];

        Console.WriteLine("### Alunos ###\n");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe o nome do aluno : ");
            string? nome = Console.ReadLine();
            nomes[i] = nome;
        }

        Console.WriteLine("\n### Notas ###\n");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Informe a notas do aluno : ");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas[i] = nota;
        }

        Console.WriteLine("\nAlunos");
        foreach (var item in nomes)
        {
            Console.Write($"{item}\t ");
        }

        Console.WriteLine("\nNotas");
        var somaNotas = 0.0;
        var totalNotas = Convert.ToDouble(notas.Count());
        foreach (var item in notas)
        {
            somaNotas += item;
            Console.Write($"{item}\t ");
        }
        Console.WriteLine($"\nMédia aritmética : {somaNotas/totalNotas}");

        Console.ReadKey();
    }
}