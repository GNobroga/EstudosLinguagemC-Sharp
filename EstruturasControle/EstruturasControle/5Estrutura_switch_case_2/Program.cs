Console.WriteLine("## Estrutura switch-case ## \n");

Console.Write("Informe o nome do mês ()\t");

//Retorna uma cópia dessa string ou cadeia
//de caracteres convertida em minúsculas.
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}


Console.WriteLine("\nFim do processamento");
Console.ReadKey();

//----------------------------------------------------------
// instrução switch aninhadas
//----------------------------------------------------------

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é Gerente(1) ou Programador(2)\t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem Vindo Gerente");
        break;
    case 2:
        Console.WriteLine("\nBem Vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Junior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Senior");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar");
        break;
}

Console.WriteLine("\nFim do processamento");
Console.ReadKey();
