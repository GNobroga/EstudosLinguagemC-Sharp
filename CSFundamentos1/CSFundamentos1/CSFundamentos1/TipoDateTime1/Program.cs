Console.WriteLine("## Struct DateTime ##\n");

Console.WriteLine("## Struct DateTime ##\n");

DateTime data = DateTime.Now;
Console.WriteLine(data);

//criar data especifica usar o formato: aaaa, mm, dd
DateTime data1 = new DateTime(2022, 09, 04);
Console.WriteLine(data1);

// criar data e hora especifica usar o formato: aaaa, mm, dd, hh, mm, ss
DateTime data2 = new DateTime(2022, 09, 04, 12, 15, 06);
Console.WriteLine(data2);

Console.ReadKey();

Console.WriteLine("\n  ------ Operações com data e hora ------- \n");

DateTime hoje = DateTime.Now;

//extraindo ano,mes,dia,hora,minuto,segundo, etc.
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);   
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//adicionar
Console.WriteLine(hoje.AddDays(30));    
Console.WriteLine(hoje.AddHours(60));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddYears(10));

// obter dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//expressar data no formato longo e abreviado
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

//expressar hora no formato longo e abreviado
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();

