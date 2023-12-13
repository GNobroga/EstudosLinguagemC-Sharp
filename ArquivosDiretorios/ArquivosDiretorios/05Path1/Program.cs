
string caminho = "d:\\dados\\txt\\poesia.txt";

char dirSeparador = Path.DirectorySeparatorChar;
Console.WriteLine("O separador de diretório padrão é: " + dirSeparador);

string[] diretorios = caminho.Split(dirSeparador);

Console.WriteLine("Os diretórios e arquivo no caminho são:");
foreach (var dir in diretorios)
    Console.WriteLine(dir);

Console.ReadLine();

string path1 = "c:\\dados";
string path2 = "txt\\poesia.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine("\nCaminho Combinado: " + pathCombinado);

Console.WriteLine("\nNome do diretório : " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nExtensão: " + Path.GetExtension(pathCombinado));
Console.WriteLine("\nNome do arquivo: " + Path.GetFileName(pathCombinado));
Console.WriteLine("\nNome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine("\nPossui extensão ? : " + Path.HasExtension(pathCombinado));
Console.WriteLine("\nContém a raiz ?: " + Path.IsPathRooted(pathCombinado));
Console.WriteLine("\nNova extensão do arquivo: " + Path.ChangeExtension(pathCombinado, ".docx"));
Console.WriteLine("\nRaiz: " + Path.GetPathRoot(pathCombinado));
//
Console.WriteLine("\nNome de arquivo aleatório: " + Path.GetRandomFileName());
Console.WriteLine("\nNome de arquivo temporário: " + Path.GetTempFileName());
Console.WriteLine("\nCaminho Temporário: " + Path.GetTempPath());

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();
Console.WriteLine("\nCaracteres inválidos em nome de arquivo: " + new string(caracteresInvalidosEmArquivo));

Console.ReadLine();