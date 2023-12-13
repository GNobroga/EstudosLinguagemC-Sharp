using _12LINQConsultas1;
//fonte de dados
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletrônicos:");
var produtoEletronicos = listaProdutos.Where(p => p.Categoria == "Eletrônicos");

foreach(var produto in produtoEletronicos)
{
    Console.WriteLine($"{produto.Nome} \t{produto.Preco:C2}");
}

// Filtrando com duas condições
Console.WriteLine("\nProdutos mais caros com estoque superior a 5: ");
var produtosCarosComEstoque = listaProdutos
                              .Where(p => p.Preco >= 2000 && p.Estoque > 5);

foreach (var produto in produtosCarosComEstoque)
{
    Console.WriteLine($"{produto.Nome}  \t{produto.Preco:C2}  Estoque: {produto.Estoque}");
}

// Filtrando com ordenação
Console.WriteLine("\nLista de produtos com estoque minimo(<10) ordenados por nome");
int minimo = 10;
var produtosEstoqueMinimo = listaProdutos
                           .Where(p => p.Estoque < minimo)
                           .OrderBy(p => p.Nome);
Console.WriteLine();
foreach (var item in produtosEstoqueMinimo)
{
    Console.WriteLine($"{item.Nome} \t Estoque: {item.Estoque}");
}

// Ordenando por mais de um criterio
Console.WriteLine("\nProdutos ordenados por categoria e nome:");
var produtosOrdenadosPorCategoriaENome = listaProdutos
                                         .OrderBy(p => p.Categoria)
                                         .ThenBy(p=> p.Nome);
string? categoriaAnterior = "";
foreach (var produto in produtosOrdenadosPorCategoriaENome)
{
    if (produto.Categoria != categoriaAnterior)
    {
        Console.WriteLine($"    {produto.Categoria}:");
        categoriaAnterior = produto.Categoria;
    }
    Console.WriteLine($"        {produto.Nome}");
}
//Cria uma lista de strings com nomes dos produtos
Console.WriteLine("\nLista dos nomes dos produtos ordenados");

var nomesDosProdutos = listaProdutos.Select(p=> p.Nome).OrderBy(nome=>nome);
foreach (var produto in nomesDosProdutos)
{
    Console.WriteLine(produto);
}

// Filtrando por preço, ordenando por nome e criando um tipo anônimo
Console.WriteLine("\nProdutos com valor menor que R$ 500 com aumento de 10% ordenados por nome:");
var resultado = listaProdutos.Where(p => p.Preco < 500)
                             .OrderBy(p => p.Nome)
                             .Select(p => new
                             {
                                 NomeProduto = p.Nome.ToUpper(),
                                 PrecoComAumento = p.Preco*1.1
                             });

foreach (var produto in resultado)
{
    Console.WriteLine($"{produto.NomeProduto}, \tPreço com aumento: {produto.PrecoComAumento:C}");
}

//outro exemplo
Console.WriteLine("\nProdutos com valor maior que R$ 2000 com desconto de 20% ordenados por preço: ");
var resultado1 = listaProdutos.Where(p => p.Preco > 2000)
                        .OrderBy(p => p.Preco)
                        .Select(p => new {
                            NomeDoProduto = p.Nome.ToUpper(),
                            PrecoComDesconto = p.Preco * 0.8 
                        });

foreach (var p in resultado1)
{
    Console.WriteLine($"{p.NomeDoProduto}, \tPreço com Desconto: {p.PrecoComDesconto:C}");
}

//Realizando cálculos de somatória, média e contagem
Console.WriteLine("\nValor médio dos produtos eletrônicos");
string categoria = "Eletrônicos";
double mediaPrecoEletronicos = listaProdutos.Where(p => p.Categoria == categoria)
                               .Average(p => p.Preco);

Console.WriteLine($"{mediaPrecoEletronicos:C}");


Console.WriteLine("\nValor total dos produtos em estoque");
double valorTotalEstoque = listaProdutos
                           .Where(p => p.Estoque > 0)
                           .Sum(p => p.Preco * p.Estoque);
Console.WriteLine($"{valorTotalEstoque:C}");

Console.WriteLine("\nQuantidade de produtos com estoque minimo (< 10)");
int estoqueMinimo = 10;
int produtosEstoqueBaixo = listaProdutos.Where(p => p.Estoque < estoqueMinimo).Count();
Console.WriteLine(produtosEstoqueBaixo);



Console.ReadKey();