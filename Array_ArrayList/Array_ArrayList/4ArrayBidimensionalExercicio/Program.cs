
string[,] dados = new string[2, 5];

Console.WriteLine("\nAtribuindo dados a um array de strings com 2 linhas e 5 colunas [2,5]\n");

Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");

Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");

// recebendo os nomes via teclado
for (int i = 0; i < dados.GetLength(0); i++)
{
    for (int j = 0; j < dados.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i},{j}]");
        dados[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteúdo do Array criado \n");

// exibindo os nomes atribuidos ao array
for (int i = 0; i < dados.GetLength(0); i++)
{
    for (int j = 0; j < dados.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {dados[i, j]}\t ");
    }
    Console.WriteLine("");
}

Console.ReadKey();

