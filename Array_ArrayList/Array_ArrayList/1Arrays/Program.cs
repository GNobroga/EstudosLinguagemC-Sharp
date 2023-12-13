
//declaração de um array
int[] numeros;
//alocação e inicializacao
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//declaração de um array
string[] nomes1;
//alocação e inicializacao
nomes1 = new string[5] {"Maria","Eva","Pedro","Ana", "Ada"} ;


//declaração e inicialização 
int[] numeros1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numeros2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numeros3 = { 1,2,3,4,5,6,7,8,9,10};

//acessando os elementos de um array
string[] nomes =  {"Ana","Maria","Marta","Paulo", "Carlos"};

Console.WriteLine(nomes[0]); //Ana
Console.WriteLine(nomes[1]); //Marria
Console.WriteLine(nomes[2]); //Marta
Console.WriteLine(nomes[3]); //Paulo
Console.WriteLine(nomes[4]); //Carlos

//declarando array
int[] numeros4;
numeros4 = new int[3];

numeros4[0] = 1;
numeros4[1] = 2;
numeros4[2] = 3;
numeros4[3] = 4;  // System.IndexOutofRangeException

Console.ReadKey();


//Acessando um array usando o laço for
int[] numeros5 = {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < numeros5.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} :  {numeros5[i]}");
}

//usando o laço forach 
foreach (int numero in numeros5)
{
    Console.Write(numero);
}

//foreach no array de string nomes
foreach(string nome in nomes)
{
    Console.Write($"{nome} ");
}






