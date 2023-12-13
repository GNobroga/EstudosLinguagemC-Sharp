
//declara
int[,] a;
//instancia 
a = new int[2, 2];

//atribui valores
a[0, 0] = 10;
a[0, 1] = 11;
a[1, 0] = 12;
a[1, 1] = 13;


Console.WriteLine("\nArray a\n");

//exibe valores do array
Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

Console.WriteLine("\nArray b\n");


//declaracao inicialização e atribuição
//int[,] b = new int[2, 2] { {20,30 }, {40,50 } };

//declaracao simplificada
int[,] b = { { 20, 30 }, { 40, 50 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

Console.ReadKey();

//Acessando arrays bidimensional com laço for e foreach
Console.WriteLine("\nAcessando array bidimensional \n");
int[,] n = { 
             { 11, 22, 33 },//  n[0,0] n[0,1] n[0,2]
             { 44, 55, 66 },//  n[1,0] n[1,1] n[1,2]   n[3,3] -> n[i,j]
             { 77, 88, 99 } //  n[2,0] n[2,1] n[2,2] 
           };

Console.WriteLine("\nLaço for \n");
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i,j]} ");
    }
    Console.WriteLine();
}


Console.WriteLine("\nLaço foreach \n");
foreach (var x in n)
{
    Console.Write($"{x} ");
}

Console.ReadKey();
