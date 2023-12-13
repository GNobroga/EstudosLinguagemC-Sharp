Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//idenficadores inválidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

//para nomes de variáveis : usa a convenção camel case
string descontoTotal;
string desconto_Total;

//constantes : recomendação é usar maiúsculas
double PI = 3.1415;
string PREFIXO = "11";
string PREFIXO_SP = "11";

Console.ReadLine();

//para nomes de classe e métodos: usa a convenção pascal case
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Macoratti");
    }
}

