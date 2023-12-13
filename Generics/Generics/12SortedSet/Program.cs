
var numeros = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
SortedSet<int> conjunto = new SortedSet<int>(numeros);
ExibirColecao(conjunto);


var frutas = new List<string> { "uva", "banana", "pera", "manga" };
SortedSet<string> minhasFrutas = new SortedSet<string>(frutas);
ExibirColecao(minhasFrutas);

var impares = new int[] { 1, 13, 7, 9, 11, 13, 5 };
SortedSet<int> meusNumeros = new SortedSet<int>(impares);
ExibirColecao(meusNumeros);

Console.ReadKey();

static void ExibirColecao<T>(SortedSet<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
        Console.WriteLine(item);
}