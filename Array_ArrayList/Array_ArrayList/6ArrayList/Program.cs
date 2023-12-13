
using System.Collections;

var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

var tipo1 = lista[0].GetType();

var lixo = new ArrayList() { 1, 2, 3 };

var tipo2 = lixo[0].GetType();

Console.WriteLine("\nArrayList original \n");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nNumero de elementos no array " + lista.Count);
lista.Clear();

Console.WriteLine("\nNumero de elementos no array depois do Clear " + lista.Count);


Console.ReadKey();

