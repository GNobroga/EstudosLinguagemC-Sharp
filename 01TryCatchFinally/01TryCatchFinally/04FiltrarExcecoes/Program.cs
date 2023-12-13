int dividendo = 0;
int divisor = 0;
try
{
    Console.WriteLine("\nInforme o dividendo");
    dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nInforme o divisor");
    divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} =  {resultado}\n");
    Console.ReadKey();
}
//catch (DivideByZeroException) when (DateTime.Now.DayOfWeek== DayOfWeek.Friday)
//{
//   Console.WriteLine("\nHoje é sexta-feira e não capturamos estas" +
//         " exceções por motivos óbvios... \n\nSextouuuu\n\n");
//   //Console.WriteLine(ex);
//}
catch (Exception) when ((dividendo / divisor) == 0)
{
    // Este bloco nunca será alcançado pois dividendo/divisor
    // lança uma exceção e na cláusula when que será definida
    // como false e será ignorada
    Console.WriteLine("Esta linha nunca será lida...");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("filtro de exceção com format");
    Console.Write(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();

