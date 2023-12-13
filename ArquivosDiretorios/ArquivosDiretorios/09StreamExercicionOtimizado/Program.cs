string caminhoArquivo = @"d:\dados\exercicio.txt";

// cria um objeto Dictionary que armazena as opções de 0 a 4
// e usa o delegate Action para mapear para cada método 
// pois todos os métodos não possuem retorno  e recebem uma string
var opcoes = new Dictionary<int, Action<string>>
{
   { 0, Sair },
   { 1, CriarArquivo },
   { 2, GravarEmArquivo },
   { 3, LerArquivo },
   { 4, ProcurarTexto }
};

Console.Write("\nCaminho do arquivo a ser criado: ");
Console.Write(caminhoArquivo);

while (true)
{
    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("1 - Criar arquivo");
    Console.WriteLine("2 - Gravar em arquivo");
    Console.WriteLine("3 - Ler arquivo");
    Console.WriteLine("4 - Procurar texto em arquivo");
    Console.WriteLine("0 - Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    if (opcoes.TryGetValue(opcao, out Action<string> acao))
    {
        acao(caminhoArquivo);
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

static void Sair(string caminhoArquivo)
{
    Environment.Exit(0);
}

static void CriarArquivo(string caminhoArquivo)
{
    try
    {
        using (FileStream fs = new FileStream(caminhoArquivo,
                                             FileMode.Create,
                                             FileAccess.Write))
        {
            Console.WriteLine($"\n>>Arquivo {caminhoArquivo} foi criado");
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void GravarEmArquivo(string caminhoArquivo)
{
    Console.Write("Digite o texto a ser gravado: ");
    string texto = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
        {
            writer.WriteLine(texto);
        }
        Console.WriteLine($"\n>>Texto gravado no arquivo {caminhoArquivo}");
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void LerArquivo(string caminhoArquivo)
{
    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine($">>Arquivo {caminhoArquivo} não encontrado");
        return;
    }
    try
    {
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void ProcurarTexto(string caminhoArquivo)
{
    Console.Write("\nDigite o texto a ser procurado: ");
    string textoProcurado = Console.ReadLine();

    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine($"Arquivo {caminhoArquivo} não encontrado");
        return;
    }
    try
    {
        bool encontrado = false;
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string linha;
            int numLinha = 0;
            while ((linha = reader.ReadLine()) != null)
            {
                numLinha++;
                if (linha.Contains(textoProcurado))
                {
                    Console.WriteLine($"\n>>Texto encontrado na linha {numLinha}: {linha}");
                    encontrado = true;
                    break;
                }
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"\n>>Texto {textoProcurado} não encontrado no arquivo {caminhoArquivo}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}