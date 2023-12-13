Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

//o uso do sufixo d para double é opcional
double n1 = 1.234;
//o uso do sufico f para float é obrigatório
float n2 = 1.234f;

//declaração em duas etapas
decimal n3;
n3 = 1.234m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadLine();

//a precisão do tipo decimal é maior por isso é mais indicada
//para cálculos financeiros com valores maiores
Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.ReadLine();



