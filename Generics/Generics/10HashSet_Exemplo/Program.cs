var alunos = new HashSet<Estudante>()
{
   new Estudante(){ ID = 101, Nome ="Marina", Curso="Moda"},
   //adicionar elemento duplicado
   new Estudante(){ ID = 101, Nome ="Marina", Curso="Moda"},
   new Estudante(){ ID = 102, Nome ="Pedro", Curso="Música"},
   new Estudante(){ ID = 103, Nome ="Silvia", Curso="Artes"}
};

Console.WriteLine("Lista de alunos\n");

foreach(var item in alunos)
{
    Console.WriteLine($"ID: {item.ID}, Nome: {item.Nome}, Curso: {item.Curso}");
}

Console.ReadKey();

public class Estudante : IEquatable<Estudante>
{
    public int ID { get; set; }
    public string? Nome { get; set; }
    public string? Curso { get; set; }

    public bool Equals(Estudante? other)
    {
        return this.ID.Equals(other?.ID);
    }
    public override int GetHashCode()
    {
        return this.ID.GetHashCode();
    }
}