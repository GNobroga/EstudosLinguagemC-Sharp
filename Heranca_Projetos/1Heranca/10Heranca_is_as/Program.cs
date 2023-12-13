
/*

    AS:
        Esse operador é usado para realizar o casting, muito semelhante 
        no Typescript. Diferente da forma tradicional que é  (int) value 
        essa forma caso não seja possível converter, será atribuido null
        a variável. (Ele so pode ser aplicado a tipos de referencia.)
        Bom para fazer downcasting ou upcasting.

    Product value = new();
    var v2 = value as string;

    IS:
        O operador is e usado para verificar se o tipo de um objeto e
        compativel com o tipo especificado ou nao. Ele retorna false
        se nao forem compativeis. Ele e basicamente o **instanceof**
        do Java e do JavaScript.


        if (variable is Product)
        {

        }
*/

using _10Heranca_is_as;

//Fazendo a conversão explícita (casting) sem usar o operador as

Object carroObj = new Carro();

try
{
    var x = (string)carroObj; //System.InvalidCastException;
}
catch (Exception ex)
{
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

//-----------------------------------------------------------
//Fazendo a conversão usando o operador as

Object carroObj1 = new Carro();

var y = carroObj1 as string;  // avalia y como null

if (y != null)
{
    Console.WriteLine("converteu obj para string");
}
else
{
    Console.WriteLine("y é null");
}

Console.ReadKey();
//------------------------------------------------------------
//Fazendo o downcasting usando o operador as

Circulo circulo1 = new Circulo();
Forma forma1 = circulo1;

//Circulo c = (Circulo)forma;
Circulo c = forma1 as Circulo;   // downcasting

if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida");
}

Console.ReadKey();

//-----------------------------------------------------------
Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo)   //verifica se o downcast é possivel
{
    Console.WriteLine("Converteu Forma para Circulo\n");

    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}


Console.ReadKey();
class Carro
{ }


