using System.Reflection;
using Novidades.c9;

var cliente1 = new Cliente("Maria", 34);

// Usando o operador with
var c2 = cliente1 with { Nome = "Livia" };

// Comparando com records
var c3 = new Cliente("Maria", 34);

if (c3 == cliente1) 
{
  Console.WriteLine("Sao iguais");
}

// Destruturando
var (Nome, Idade) = c3;

// Inferindo lambdas
var parse = (string s) => int.Parse(s); // Func<string, int>

// Inferindo tipo retorno em lambdas
var parse2 = object (string s) => s;

// Atributos em expressoes lambdas (Vulgo anotações)
// /[Annotation] string (string s) => s;
var imprimir = string (string s) => s;

// Definindo literal de string, semelhante ao uso de @

var text = """
    dsdsdasd
""";

// Interpolacao com string

var textSum = $$""" {21 + 34} = {{21 + 24}}""";

Console.WriteLine(textSum);


// Verifica posicao

int[] values = {1, 2, 3};

if (values is [_, 2, _]) // O dois esta na posicao 2
{
  Console.WriteLine("SIM");
}

// Verificar se a sequencia termina com 8

int[] numeros = { 1, 2, 3, 4 ,5 };

if (numeros is [.., 8])  // verifica se a sequencia termina com 8
{

}

if (numeros is [.., 4, _])  // verifica se o penultimo elemento e 4 da sequencia
{
  Console.WriteLine("Sim e 4");
}


if (numeros is [1, .., 5])  // verifica se o primeiro elmemento e 1 e o ultimo e 5
{
  Console.WriteLine("Sim 1 e 5");
}


int[] v = {1, 2, 3, 4, 5, 8};
if (v is [.., var penultimo, var ultimo]) 
{
  Console.WriteLine($"Penultimo {penultimo} Ultimo {ultimo}");
}

int c = 1;

Console.WriteLine(nameof(c));

P p = new();

Console.WriteLine(p.Meu());

// Lendo anotacao (atributos)
Derivative d = new();

Type t = d.GetType();

var attributes = t.GetCustomAttributes();

foreach(var attribute in attributes) 
{
  if (attribute is MakeSomething) 
  {
    MakeSomething makeSomething = attribute as MakeSomething;

    Console.WriteLine(makeSomething.Phrase);
  }
}


// Declarando metodos com retorno com retorno default.
public class P 
{
  public int Meu() => default;
}



[MakeSomething]
public class Derivative 
{

}
file class MakeSomething : Attribute 
{
  public string Phrase;

  public MakeSomething(string phrase) => Phrase = phrase;
}