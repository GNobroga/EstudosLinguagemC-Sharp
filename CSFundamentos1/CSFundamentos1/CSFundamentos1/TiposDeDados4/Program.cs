Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

//as strings são tipos de referência
//e são imutáveis
string nome = "Curso C#";
string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

//aqui estamos criando 3 strings distintas na memória
string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";


//A classe StringBuilder pode ser usada para tratar
//strings pois otimiza o uso da memória

//o tipo dynamic tem um comportamento igual ao object
//mas são resolvidos em tempo de execução(runtime)
dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();
