using _11Heranca_abstract;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado (m)");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nA área do quadrado é : {q.Area} m2");
Console.WriteLine($"\nO perímetro do quadrado é {q.Perimetro} m "); 
Console.WriteLine($"\nO quadrado tem a cor : {q.Cor}");
Console.ReadKey();