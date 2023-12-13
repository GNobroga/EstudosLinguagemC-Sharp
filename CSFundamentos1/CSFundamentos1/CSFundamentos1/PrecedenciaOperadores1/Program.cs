Console.WriteLine("## Precedência de operadores ##\n");


int x = 10 - 2 * 3;
Console.WriteLine(x);
//int x = (10 - 2) * 3;
Console.WriteLine(x);


bool b1 = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b1);
//bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);

int a = 5, b = 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);

int a1 = 5, b2 = 6, c1 = 3;
int resultado = a1 = b2 = c1;
Console.WriteLine(a1);
Console.WriteLine(b2);
Console.WriteLine(c1);
Console.WriteLine(resultado);

Console.ReadKey();

