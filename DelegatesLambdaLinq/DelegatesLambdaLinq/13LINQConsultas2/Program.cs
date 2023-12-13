using _13LINQConsultas2;
//fonte de dados
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\n-First - Localiza o primeiro elemento");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C2}");

Console.WriteLine("\n-First - Localiza o primeiro elemento usando um critério de Nome");
try
{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Cadeira");
    Console.WriteLine($"{primeiraOcorrencia1.Nome} \t{primeiraOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); ;
}

Console.WriteLine("\n-FirstOrDefault - Localiza o primeiro elemento usando um critério de Nome");
var primeiraOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Nome == "Cadeira");
if(primeiraOcorrencia2 != null)
    Console.WriteLine($"{primeiraOcorrencia2.Nome} \t{primeiraOcorrencia2.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");

Console.WriteLine("\n-Last - Localiza o último elemento");
var ultimoProduto = listaProdutos.Last();
Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");

Console.WriteLine("\n-Last - Localiza o último elemento usando um critério de Nome");
try
{
    var ultimaOcorrencia1 = listaProdutos.Last(p => p.Nome == "Cadeira");
    Console.WriteLine($"{ultimaOcorrencia1.Nome} \t{ultimaOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n-LastOrDefault - Localiza o último elemento usando um critério de Nome");
var ultimaOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Nome == "Cadeira");

if (ultimaOcorrencia2 != null)
    Console.WriteLine($"{ultimaOcorrencia2?.Nome} \t{ultimaOcorrencia2?.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");

Console.WriteLine("\n-Single - Localiza o único elemento da sequência usando o critério de Nome");
try
{
    var unicoProduto = listaProdutos.Single(p => p.Nome == "Cadeira");
    Console.WriteLine($"{unicoProduto.Nome} \t{unicoProduto.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n-SingleOrDefault - Localiza o último elemento usando um critério de Nome");
try
{
    var unicaOcorrencia2 = listaProdutos.SingleOrDefault(p => p.Nome == "Cadeira ");

    if (unicaOcorrencia2 != null)
        Console.WriteLine($"{unicaOcorrencia2?.Nome} \t{unicaOcorrencia2?.Preco:C2}");
    else
        Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();