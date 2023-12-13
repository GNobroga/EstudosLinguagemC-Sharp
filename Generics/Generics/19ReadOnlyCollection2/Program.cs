
using System.Collections.ObjectModel;

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

//alterações não permitidas
//exoPlanetas[0]= "Kepler-442b";
//exoPlanetas[0] = new ExoPlaneta() { Nome = "Kepler-442b" };

exoPlanetas[0].Nome = "Kepler-442b";

Console.WriteLine("\nLista de exoplanetas : \n");
foreach (var item in exoPlanetas)
    Console.WriteLine(item.Nome);


Console.ReadKey();

class ExoPlaneta
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
