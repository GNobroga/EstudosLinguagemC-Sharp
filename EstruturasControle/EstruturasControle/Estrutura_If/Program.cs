Console.WriteLine("## Instrução if ##\n");

Console.Write("Cliente Especial (S/N)\t");
var resposta = Console.ReadLine();

if (resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}

Console.ReadKey();

bool clienteEspecial = false;
Console.Write("Cliente Especial (S/N)\t");
var resposta2 = Console.ReadLine();

if (resposta2 == "S")
{
    clienteEspecial = true;
}
if (clienteEspecial == true)
{
    Console.WriteLine("Desconto de 10%");
}
Console.ReadKey();

Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if(x>y)
    Console.WriteLine("x é maior que y");

if(x<y)
    Console.WriteLine("x é menor que y");

if(x == y)
    Console.WriteLine("x é igual a y");

Console.ReadKey();
