Console.WriteLine("## break e continue ##\n");

//------------------------------------
// instrução break para sair do loop for
//------------------------------------
for (; ; )
{
    Console.WriteLine("Tecle algo (X sai) ");

    string opcao = Console.ReadLine();

    Console.WriteLine(opcao.ToUpper());

    if (opcao == "x" || opcao == "X")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//--------------------------------------------
// instrução continue no loop for
//-----------------------------------------------

for (int i = 1; i <= 10; i++)
{
    if (i == 4)
        continue;

    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//--------------------------------------------
// instrução continue no loop while
//-----------------------------------------------
int n = 1;
while (n < 10)
{
    if (n == 5)
    {
        n = n + 1;
        continue;
    }

    Console.WriteLine($"n = {n}");
    n++;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();


//--------------------------------------------
// instrução break continue no mesmo loop for
//-----------------------------------------------

for (int i = 1; i < 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();