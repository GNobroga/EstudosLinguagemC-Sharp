using _09DelegatesExercicio;
var listaDePessoas = Pessoa.GetPessoas();

//Console.WriteLine("1- Imprime o nome/idade de cada pessoa usando um delegate Action<Pessoa>");
//Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " "+ p.Idade);
//listaDePessoas.ForEach(imprimirNome);

//Console.WriteLine("2- Filtra pessoas maiores de 18 anos usando um delegate Predicate<Pessoa>");
//Predicate<Pessoa> filtrarIdadeMaiorQue18 = p => p.Idade > 18;
//var pessoasMaiores18Anos = listaDePessoas.FindAll(filtrarIdadeMaiorQue18);
////Usando o delegate Action para exibir o resultado
//pessoasMaiores18Anos.ForEach(imprimirNome);

//Console.WriteLine("\n3- Obtém nome/idade da pessoa mais velha utilizando um delegate Func<Pessoa, int>");
//Func<Pessoa, int> obterIdade = p => p.Idade;
//var pessoaMaisVelha = listaDePessoas.MaxBy(obterIdade);
////int idadeMaxima = listaDePessoas.Max(obterIdade);
////var pessoaMaisVelha = listaDePessoas.Find(p=> p.Idade == idadeMaxima);
//Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + " idade: " + pessoaMaisVelha.Idade);
//Console.ReadKey();

/////////////////////////////////////////////////////
///////////////////// Código otimizado //////////////
/////////////////////////////////////////////////////
//1- No primeiro problema, ao invés de utilizar o delegate imprimirNome,
//a expressão lambda p => Console.WriteLine(p.Nome) é utilizada diretamente no método ForEach.
//2- No segundo problema, a expressão lambda p => p.Idade > 18 é utilizada
//diretamente no método FindAll.
//3- No terceiro problema, o método Aggregate da lista é utilizado para obter
//a pessoa mais velha.
/////////////////////////////////////////////////////
// 1- Imprime o nome de cada pessoa utilizando um delegate Action<Pessoa>
Console.WriteLine("\nLista de Pessoas");
listaDePessoas.ForEach( p => Console.WriteLine(p.Nome + " " + p.Idade));

Console.WriteLine("\nLista de Pessoas maiores de 18 anos");
// 2- Filtra as pessoas com idade maior que 18 utilizando um delegate Predicate<Pessoa>
List<Pessoa> pessoasMaioresDe18Anos = listaDePessoas.FindAll(p => p.Idade > 18);
listaDePessoas.ForEach(p => Console.WriteLine(p.Nome + " " + p.Idade));

Console.WriteLine("\nPessoa mais velha");
// 3- Obtém o nome da pessoa mais velha utilizando um delegate Func<Pessoa, int>
Pessoa pessoaMaisVelha = listaDePessoas.Aggregate((p1, p2) => p1.Idade > p2.Idade ? p1 : p2);
Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + " "+ pessoaMaisVelha.Idade);

Console.ReadKey();