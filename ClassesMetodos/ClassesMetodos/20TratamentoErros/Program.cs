Console.WriteLine("## Divisão de números inteiros ##");
Console.WriteLine("  x / y ");

Console.WriteLine("\nInforme o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");

    Console.WriteLine($"\n Erro: <<< {ex.Message} >>>");
    Console.WriteLine($"\n Detalhes : {ex?.StackTrace?.ToString()}");

}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadKey();