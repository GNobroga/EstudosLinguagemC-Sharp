Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<bool> b = null;
Nullable<double> d = null;
Nullable<float> f = null;

Console.WriteLine($"i={i}");
Console.WriteLine($"b={b}");
Console.WriteLine($"d={d}");
Console.WriteLine($"f={f}");

Console.ReadKey();

int? vari = null;
bool? varb = null;
double? vard = null;
float? varf = null;

Console.WriteLine($"i={vari}");
Console.WriteLine($"b={varb}");
Console.WriteLine($"d={vard}");
Console.WriteLine($"f={varf}");

Console.ReadKey();

int a1 = 100;
int? b1 = a1;
Console.WriteLine(b1);
Console.ReadKey();

int? a2 = null;
int b2 = a2 ?? 0;
Console.WriteLine(b2);

Console.ReadKey();

int? x = 4;
int y = 3;
//int z = x * y;
Console.WriteLine(z);
Console.ReadLine();

int? x1 = 4;
int? y1 = 3;
int? z1 = x1 * y1;
Console.WriteLine(z1);

Console.ReadKey();

int? b3 = 100;
if (b.HasValue)
{
    Console.WriteLine($"b3 is {b3.Value}");
}
else
{
    Console.WriteLine("b3 does not have a value");
}

Console.ReadKey();