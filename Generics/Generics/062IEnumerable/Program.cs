
var lista = new List<int> {  1, 2, 3, 4, 5 };
string[] array = { "Ana", "Maria", "Paulo", "José" };

var dicionario = new Dictionary<int, int>()
{
    { 1, 10 },
    { 2, 20 },
    { 3, 30 },
};
var conjunto = new HashSet<int>() { 1, 2, 3, 4, 5 };

//ImprimirNoConsole(lista);
ImprimirNoConsole(array);
//ImprimirNoConsole(dicionario);
//ImprimirNoConsole(conjunto);





Console.ReadKey();

void ImprimirNoConsole<T>(IEnumerable<T> lista)
{
    Console.WriteLine();
    foreach(var item in lista)
    {
        Console.Write($"{item} ");
    }
}