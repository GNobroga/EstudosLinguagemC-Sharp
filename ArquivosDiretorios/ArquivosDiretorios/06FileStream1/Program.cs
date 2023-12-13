
string caminhoArquivo = @"d:\dados\poesia.txt";

//FileStream fs = null;
StreamReader leitor = null;

try
{
	//fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
	leitor = File.OpenText(caminhoArquivo); //new StreamReader(fs);

	string? linha;
	while((linha = leitor.ReadLine()) != null)
	{
		Console.WriteLine(linha);
	}
}
catch(IOException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
	if (leitor != null) leitor.Close();
	//if (fs != null) fs.Close();
}
Console.ReadKey();
