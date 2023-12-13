using System.Collections;

//Análise da Segurança de Tipagem

// Quando executamos o código, qualquer tipo de referência ou valor
// que é adicionado a um ArrayList é implicitamente convertido via
// typecast para System.Object. 
//
// Se os itens são tipos de valor, eles devem sofrer um boxing quando
// adicionado à lista, e unboxing quando eles são recuperados. 
// 
// Com isso temos que realizar as operações para converter de Object
// para o tipo de dados especificado quando formos tratar com os 
// elementos da coleção e isso esta sujeito a erros de incompatibilidade
// de tipo

// Usando Generics não temos mais a necessidade de que todos os itens
// a sejam convertidos para Object e também permitimos que o compilador
// faça alguma verificação de tipo

ArrayList lista = new ArrayList
{
    50,  // cast boxing
    "Generics", //cast
    new Aluno()   
};  

foreach (var obj in lista)
{
    Console.WriteLine(obj);  //unboxing
}

Console.ReadLine();

public class Aluno
{
    public string? Nome { get; set; }
}