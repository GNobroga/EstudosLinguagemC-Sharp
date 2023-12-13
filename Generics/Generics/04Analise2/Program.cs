using System.Collections;

//Análise de Desempenho

// Quando executamos o código, qualquer tipo de referência ou valor
// que é adicionado a um ArrayList é implicitamente convertido via
// typecast para System.Object. 
// Se os itens são tipos de valor, eles devem sofrer um boxing quando
// adicionado à lista, e unboxing quando eles são recuperados. 
// A coersão , boxing e unboxing são operações que degradam o desempenho,
// e o efeito de boxing e unboxing pode ser bastante significativo em
// cenários onde você deve percorrer grandes coleções.

ArrayList obj = new ArrayList();

//boxing - converter o tipo por valor para tipo por referência
obj.Add(50);           

int x = (int)obj[0];   //realiza o unboxing

foreach (int i in obj)
{
    Console.WriteLine(i);   //realiza unboxing
}