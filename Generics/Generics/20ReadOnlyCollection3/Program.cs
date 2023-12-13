using System.Collections.ObjectModel;
Console.ReadKey();
public class GerenciaExoPlanetas
{
    private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas();

    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); }
    }
    public void AdicionaPlaneta(ExoPlaneta planeta)
    {
        exoPlanetas.Add(planeta);
    }
}
public class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
          new ExoPlaneta() { Nome = "Proxima Centauri b" },
          new ExoPlaneta() { Nome = "Kleper 186-f" },
          new ExoPlaneta() { Nome = "Gliesi 1061-c" },
        };
    }
}