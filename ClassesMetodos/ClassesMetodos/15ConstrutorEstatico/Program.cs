Console.WriteLine("## Construtor estático ##\n");

//invoca o construtor parametrizado e o estatico
Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

//invoca somente o construtor parametrizado
Pessoa p2 = new Pessoa(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Console.ReadKey();


