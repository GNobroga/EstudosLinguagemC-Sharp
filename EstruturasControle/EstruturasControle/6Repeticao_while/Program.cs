Console.WriteLine("## Instrução While ##\n");

var i = 1;
while (i <= 10)
{
    Console.WriteLine($"i = {i} ");
    i++;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//-------------------------
// Outra abordagem 
//-------------------------
var j = 10;
while (j > 0)
{
    Console.WriteLine($"j = {j} ");
    j--;
}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
//-------------------------
// Outra abordagem 
//-------------------------
int numero;
int contador = 1;
Console.Write("\nDigite um número maior que zero(0) : \t");

numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"\n### Tabuado do {numero} ###\n");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero !! ");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();