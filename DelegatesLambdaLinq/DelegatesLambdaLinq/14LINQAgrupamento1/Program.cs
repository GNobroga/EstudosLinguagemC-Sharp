using _14LINQAgrupamento1;
var listaProdutos = Produto.GetProdutos();

var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria);

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine(grupo.Key + " : " + grupo.Count());

    foreach (var produto in grupo)
    {
        Console.WriteLine($"  {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
    }
}

Console.ReadKey();