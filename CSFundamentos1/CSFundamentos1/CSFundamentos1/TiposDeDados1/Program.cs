Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();

//declarando variáveis de valor integrais
byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;

//podemos alterar o valor de uma variável
valor3 = 1000;
uint valor4 = 2147483647;
long valor5 = -21474836489;

//declaração de constante usa a palavra-chave const
const int valor6 = 999;
//não podemos alterar o valor de uma constante 
//o compilador vai indicar um erro
//valor6 = 888;

//declarando variáveis do mesmo tipo na mesma linha

int var1=8, var2=9, var3=10;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);

Console.ReadLine();


