Console.WriteLine("## Operadores Relacionais ##\n");

int x1 = 10;
int y1 = 20;

Console.WriteLine($"Valor de x1 = {x1}");
Console.WriteLine($"Valor de y1 = {y1}\n");

//podemos exibir o resultado diretamente ou armzenar em uma variavel (bool)
Console.WriteLine(x1 == y1);
bool resultado = x1 == y1;
Console.WriteLine(resultado);

//tipos por valor - comportamento - compara o valor da variavel
int x = 10;
int y = 20;

Console.WriteLine($"Valor de x = {x}");
Console.WriteLine($"Valor de y = {y}\n");

Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(y >= x);
Console.WriteLine(y <= x);
Console.WriteLine(y != x);

Console.ReadKey();

//tipo por referencia - string : podemos usar == ou Equals para comparar
string a = "Curso";
string b = "curso";

Console.WriteLine($"Valor de a {a}");
Console.WriteLine($"Valor de b {b}");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));

Console.ReadKey();