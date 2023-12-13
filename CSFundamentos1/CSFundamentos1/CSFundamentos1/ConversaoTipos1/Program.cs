Console.WriteLine("## Conversão de tipos ##\n");

// Não é possível declarar uma variável
// com o mesmo nome duas vezes"
//int a = 1;
//string a = "um";

// conversão implicita não permitida entre
// tipos não compatíveis (maior para menor)
//int a = 1;
//a = "um";

//aqui temos uma conversão que esta sendo feita
//de forma automatica
int i = 100;
double d = i;
Console.WriteLine(d);

//byte -> 1 byte
//short -> 2 bytes
//int  -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

// conversão implicita permitida entre
// tipos compatíveis(menor para o maior)
//Console.WriteLine("\n-- Conversão Implícita --\n");

int numeroInt = 2147483647;
long numeroLong = numeroInt;
double numeroDouble = numeroInt;
float numeroFloat = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDecimal);

Console.ReadLine();

Console.WriteLine("\n Conversão Explícita \n");

double varDouble = 12.456;    //8 bytes
int varInt = (int)varDouble;  //4 bytes (perda de precisão)

Console.WriteLine(varInt);

//Tomar cuidado com expressões numericas
//pois o compilador primeiro calcula o resultado no tipo
//de dados definido
int num1 = 10;
int num2 = 4;
float resultado = (float)num1 / num2;   // 10/4 = 2.5
Console.WriteLine(resultado);

Console.ReadLine();

Console.WriteLine("\n Conversão usando o método ToString() \n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.568696m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.ReadLine();

Console.WriteLine("\n Conversão usando os métodos da classe Convert \n");

int valorInt1 = 10;
double valorDouble1 = 5.35;
bool valorBool1 = true;

Console.WriteLine(Convert.ToString(valorInt1));
Console.WriteLine(Convert.ToDouble(valorInt1));
Console.WriteLine(Convert.ToString(valorBool1));
Console.WriteLine(Convert.ToInt32(valorDouble1));

int varInt1 = 100000;
Console.WriteLine(Convert.ToByte(varInt1));

Console.ReadLine();

Console.WriteLine("\n OverflowException \n");
Console.WriteLine("Conversão com estreitamento e perda de dados\n");

int varInt2 = 10000;
Console.WriteLine(Convert.ToByte(varInt2));

Console.ReadLine();


