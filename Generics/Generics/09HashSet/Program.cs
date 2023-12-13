
var timesSP = new HashSet<string> {"Santos","Palmeiras","São Paulo" };
var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
}
var resultado = timesBA.Remove("Juazeiro");

if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("timesSP é um subconjunto de timesMundiais\n");
}

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
}

if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
}

if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos");
}

Console.WriteLine("\n-Juntando os HashSet<T> : SP , RJ e BA ");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);

ExibirColecao(timesSP);

Console.WriteLine("\nJuntando os Times de SP, RJ e BA ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);

Console.WriteLine("\nInterseção de dois HashSet<T> : timesSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP com SymmetricExceptWith ");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nRemove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.Write("Fim do processamento...");

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item} ");
    }
}