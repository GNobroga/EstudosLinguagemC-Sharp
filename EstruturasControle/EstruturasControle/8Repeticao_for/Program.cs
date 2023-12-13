Console.WriteLine("## Instrução for ##\n");

double resultado, numero;
double i;

Console.WriteLine("Infome o numero inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (i = 1; i <=20; i=2)
    {
        resultado = numero * i;
        //Console.WriteLine(numero + " X " + i + " = " + resultado);
        Console.WriteLine($"{numero} X  {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
