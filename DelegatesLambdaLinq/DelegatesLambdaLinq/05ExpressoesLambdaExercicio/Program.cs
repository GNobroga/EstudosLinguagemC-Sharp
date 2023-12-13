using _05ExpressoesLambdaExercicio;

List<Produto> produtos = new List<Produto>
{
  new Produto { Nome = "Produto A", Preco = 10 },
  new Produto { Nome = "Produto B", Preco = 100 },
  new Produto { Nome = "Produto C", Preco = 50 },
  new Produto { Nome = "Produto D", Preco = 75 },
  new Produto { Nome = "Produto E", Preco = 45 }
};

//usando um método nomeado separado
//var produtosFiltrados = produtos.Where(FiltraProduto);

//usando um método anônimo
//var produtosFiltrados = produtos.Where(delegate (Produto produto)
//{
//    return produto.Preco >= 50;
//});
//usando uma expressão lambda
var produtosFiltrados = produtos.Where(produto=> produto.Preco >= 50);

foreach(var produto in produtosFiltrados)
{
    Console.WriteLine(produto.Nome + " - " + produto.Preco);
}

Console.ReadKey();
//static bool FiltraProduto(Produto produto)
//{
//    return produto.Preco >= 50;
//}