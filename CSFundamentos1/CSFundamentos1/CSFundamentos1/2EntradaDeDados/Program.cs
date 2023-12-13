using System.Globalization;

Console.WriteLine("## Entrada de dados ##\n");

Console.Write("Nome :");
string? nome = Console.ReadLine();

Console.Write("Data de Nascimento :");
DateTime nascimento = Convert.ToDateTime(Console.ReadLine());

Console.Write("Salário :");

decimal salario = Convert.ToDecimal(Console.ReadLine(),
                   CultureInfo.InvariantCulture);

Console.WriteLine($"\n{nome?.ToUpper()}");
Console.WriteLine($"\n{nascimento.ToShortDateString()}");
Console.WriteLine($"\n{salario.ToString("c")}");

Console.ReadKey();