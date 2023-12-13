
List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

var resultado = (from m in nomes
                where m.Contains('o')
                select m).ToArray();

ExibirResultado(resultado);

var resultado1 = nomes.Where(n => n.Contains('a')).ToList();

ExibirResultado(resultado1);

Console.ReadKey();

static void ExibirResultado(IEnumerable<string> resultado)
{
    foreach (var item in resultado)
        Console.WriteLine(item);
}