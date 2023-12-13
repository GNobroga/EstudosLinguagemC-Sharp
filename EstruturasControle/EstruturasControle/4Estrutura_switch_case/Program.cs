Console.WriteLine("## Estrutura switch-case ## \n");

int compra = 600;

Console.WriteLine("Valor da Compra R$ 600,00\n");

Console.Write("Informe o no. de parcelas (1 a 3)\t");

var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine($"\nValor inválido, informe 1, 2 ou 3 !!!");
        break;
}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//---------------------------------------------

int numero;

Console.Write("Informe um número inteiro: \t");
numero = Convert.ToInt32(Console.ReadLine());
switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é par");
        break;

    case 1:
        Console.WriteLine("\n" + numero + "  é impar");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
