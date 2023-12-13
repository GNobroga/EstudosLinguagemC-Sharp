
Dictionary<int,int> dic1 = new Dictionary<int,int>();
var dic2 = new Dictionary<int,int>();
dic2.Add(2, 100);
dic2.Add(4, 400);
dic2.Add(3, 400);

var dic3 = new Dictionary<int, int>()
{
    {1,100 },
    {2,200}, 
    {3,300}
};

Console.WriteLine("\n-Incluir elemento com chave(3) duplicada");
try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n-Usando o método TryAdd para a chave 3");
var resultado = dic3.TryAdd(3, 333);
Console.WriteLine("Elemento foi incluido ? " + resultado);

Console.WriteLine("\n-Incluindo o elemento com chave 7 e valor 7000");
if (!dic3.ContainsKey(7))
{
    dic3.Add(7, 7000);
    Console.WriteLine(dic3[7]);
}

Console.WriteLine("\n-Usando ContainsValue");
if (dic3.ContainsValue(7000))
{
    Console.WriteLine("O valor existe no Dicionário");
}
else
{
    Console.WriteLine("Não valor não existe no Dicionário");
}

Console.WriteLine("\n-Alterando o valor do elemento com chave 7");
Console.WriteLine("Valor atual do item " + dic3[7]);
if (dic3.ContainsKey(7))
{
    dic3[7] = 7777;
    Console.WriteLine("Valor alterado do item " + dic3[7]);
}

Console.WriteLine("\n-Tentando obter elemento com chave(5) inexistente");

try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n-Usando TryGetValue() para a chave 5");

if(dic3.TryGetValue(7,out int valor))
{
    Console.WriteLine("Valor para a chave 7 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrada");
}

dic3.Add(6, 6666);
dic3.Add(4, 4444);

Console.WriteLine("\n-Percorrendo o dicionário e exibindo os itens (foreach) ");

foreach(var item in dic3)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine("\n-Ordenando os elementos do dicionário(SortedDictionary/LINQ) ");

//var dic3Ordenado = new SortedDictionary<int, int>(dic3);
var dic3Ordenado = dic3.OrderBy(x => x.Key);

foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.ReadKey();