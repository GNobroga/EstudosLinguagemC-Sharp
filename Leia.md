# Tipo Dinamic

O Tipo dynamico permite eu acessar uma propriedade sem que ela talvez exista, diferente o obj que não permite isso. 

No caso abaixo, caso eu declara-se a variável como object eu não conseguiria acessar obj.Name pois o compilar iria reclamar.

```cs
  dynamic obj = new { Name = "Gabriel" };

  obj.Name; // Permite eu acessar essa propriedade.
```

# Record

É o novo tipo do C#, ele é imutável e serve para criar objetos que não sofrem tantas modificações.

Utilização:

```cs
  public record Person (string name);
```

É possível especificar atributos obrigatórios. A idade é atributo obrigatório no código abaixo.

```cs
  public record Person (string name) 
  {
    public required int Age { get; init; }
  }

Person person = new("Nancy") { Age = 21 };

```

Também é possível copiar um objeto imútavel alterando uma de suas propriedades.

```cs
  public record Person(string Name);

  Person person = new("Gabriel") { Age = 21 };
  Person person2 = person with { Name = "Gabriel" };
```

# Objetos anônimos

**with** - Esse operador permite criar uma cópia de objeto anônimo com as propriedades de um já existente, podendo alterar uma propriedade.

```cs

  var person = { Name = "Gabriel" };
  var copy = person with { Name = "José" };

```

# Interface IEnumerable

É um interface que tem um método que classes podem implementar para ter uma implementação de Enumerator.

Podemos usar **yield** para implementar um iterador e gerar os valores um a um. Semelhante ao JavaScript e Python.

Geração sincrona.

```cs
  foreach(int i in GerarMeses()) 
  {
    Console.WriteLine(i);
  }

  static IEnumerable<int> GerarMeses() 
  {
    for (int i = 0 ; i < 100 ; i++) 
    {
      yield return i;
    }
  }
```
Geração assincrona (antigo), não permite usar o foreach.

```cs
  static async Task<IEnumerable<string>> GerarMeses() 
  {
    yield return "dsd";
    await Task.Delay(200);
    yield return "dsd";
    yield return "dsd";
  }
```

Geração assincrona (novo), ele permite usar o foreach.

```cs
  static async IAsyncEnumerable<string> GerarMeses() 
  {
    yield return "dsd";
    await Task.Delay(200);
    yield return "dsd";
    yield return "dsd";
  }

  await foreach(string v in GerarMeses()) 
  {
    Console.WriteLine(mes);
  }
```

# Controlando Threads com semáforos.

É usado para limitar o número de threads que podem ter acesso a um recurso compartilhado de forma simultânea. 

Por exemplo, eu tenho uma operação e quero que só três threads trabalhem por vez nessa operação, eu posso usar essa classe para limitar isso.

```cs
  Semaphore semaforo = new Semaphore(initialCount: 1, maxiumCount: 3);
```

Também existe a classe

```cs
  SemaphoreSlim semaforo = new SemaphoreSlim(initialCount: 1);
```

# Dicas 

Em C# é possível instanciar uma classe a partir do nome dela.

```cs
  Type dynamicType = Type.GetType("Product", true, true);
  Product product = Activator.CreateInstance(dynamicType) as Product;
```

# EF Core Fluent Api

É usada para configurar classes de domínio e substituir as convenções do EF Core.

Se baseia no padrão de Design da API Fluent no qual o resultado é formulado pelo encadeamento de métodos.

Resumindo é uma forma de mapear as entidades ou customizar sem utilizar attributes do EF.

A classe ModelBuilder do EF Core atua como uma Fluent API.

Permite Configurar os seguintes aspectos do Modelo:

1. Model - Schema Padrão, DB Functions, etc;

2. Entity - PrimaryKey, Schema, Index, Relacionamentos, Etc;

3. Property - Nome da coluna, valor padrão, tipo de dados, nulabildiade, etc;