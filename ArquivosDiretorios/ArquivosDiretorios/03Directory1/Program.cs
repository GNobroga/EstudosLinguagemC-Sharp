var caminhoDiretorio = @"d:\dados\MeuDiretorio";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

Console.WriteLine("\nRenomeando(Mover) um diretório");

try
{
    if(Directory.Exists(caminhoDiretorio))
    {
       Directory.Move(caminhoDiretorio, caminhoDestino);
       Console.WriteLine("Diretório renomeado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório  {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();