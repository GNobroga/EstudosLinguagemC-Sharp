# Delegate

No português **Delagate** signfica delegar. 

Ele funciona como as interfaces funcionais no Java. São usados para criar callbacks etc.

```cs
  [modificador-acesso] delegate [tipo-retorno] [nome-delegate]([parametros]);

  public delegate void Calc(int x, int y);
```

Eu posso invocar um delagete, usando o Invoke ou usando a execução de função normal.

# Multicast Delegate

Podemos concaternar vários métodos que implementam o delegate.

Quando invocamos o multicast delegate 

Ele é útil em situações em que várias ações precisam ser executadas quando um evento ocorrer.

**+=** - Para adicionar um delegate

**-=** - Para remover um delegate

```cs

  Action multiDelegate = sub;
  multiDelegate += sum;

  multiDelegate(10, 20);

  static int sub(int x, int y)
  {
    return x - y;
  }
  
  static int sum(int x, int y) 
  {
    return x + y;
  }

  public delegate int Action(int x, int y);

```

Se tiver um retorno ele vai pegar o retorno do ultimo metodo adicionado.


# Funcao Anonimas

É uma função que não possui nome e pode ser definida usando a palavra chave **delegate** e
pode ser atribuido a uma variável do tipo **delegate**.

Lambdas sao funcoes anonimas tambem.

```cs

  Show show = delegate () 
  {
    Console.WriteLine("OI");
  };

  show(); // Output "OI"

  public delegate void Show();

```

Outra forma 

```cs

  Show show = () => Console.WriteLine("OI");
  show(); // Output "OI"


  public delegate void Show();

```


# Delegates Predefinos em C#

**Predicate<T>**

**Action<T>** - Representa um metodo que nao retorna um valor, mas pode receber 16 argumentos de entrada. Util para executar uma acao sem retornar nada.

**Func<T, TResult>** - Recebe de um ate 16 argumentos do tipo T e retorna um valor do Tipo TResult.

# Usando o in  e out com Generic

O **in** serve para dizer que vamos passar um tipo mais Generico de argumento.

Exemplo: Animal, Gato.

Animal e o tipo Generico.

Ele e usado em casos de herencas.

O **out** e o oposto.

```cs
using System;

public delegate void Contravariante<in T>(T input);

public class Animal { }

public class Gato : Animal { }

public class Exemplo
{
    public static void ImprimirAnimal(Animal animal)
    {
        Console.WriteLine("Animal: " + animal.GetType().Name);
    }

    public static void Main(string[] args)
    {
        Contravariante<Animal> imprimirAnimal = ImprimirAnimal;
        Contravariante<Gato> imprimirGato = imprimirAnimal;
        
        imprimirGato(new Gato());
    }
}
```

# Eventos 

Permite notificar uma ou várias classes quando uma ação acontece. Ele utiliza **delegates** para
concaternar os inscritos no evento e para executar a ação de enviar o enviado existe um método
específico na classe pra isso. 

Nós só colocamos a palavra event na declaração do **delegate** para que não seja setado null
e os inscritos sejam removidos de forma erroanea.

1 - Criar um Delegate

```cs

  delegate void PedidoEventHandler();

```

2 - Criar o Event

```cs
    public event nome-do-delagete? OnCriarPedido;
```

```cs
  class Pedido 
  {
    // Se eu nao declarar a palavra event, a pessoa pode setar null direto no OnCriarPedido que e um delagete e interromper tudo.
    public event PedidoEventHandler? OnCriarPedido; // Isso e uma variavel que recebe um Tipo do Delegate, podendo adiciona multicast.
    

    public void CriarPedido() // Metodo para Ativar o Evento
    {
      Console.WriteLine("Pedido criado");

      if (OnCriarPedido != null) // Como o OnCriarPedido e um delegate, caso ele nao tenha nada nao vai dispatar.
      {
        OnCriarPedido();
      }
    }
  }

  var pedido = new Pedido();

  pedido.OnCriarPedido += Email.Enviar;  
  pedido.OnCriarPedido += SMS.Enviar; // Esses metodos precisam ter a mesma assinatura do delegate.

  pedido.CriarPedido(); // Ao chamar esse metodo ele ira propagar para os ouvientes.


```

**+=** - Para adicionar um manipulador de evento.

**-=** - Para remover um manipulador de evento.

# Delegates de EventHandler Predefinidos

**EventHandler** - Representa um metodo que vai manipular um evento que nao possui dados.

```cs
  public delegate void EventHandler(object? sender, EventArgs e);
```

```cs

  var obs = new Observer();

  obs.OnObserver += subscribe;

  obs.RaiseEvent();

  static void subscribe(object? sender, EventArgs e) 
  {
    if (sender is Observer) 
    {
      var obs = sender as Observer;

      Console.WriteLine(obs.Name);
    }
  }

  class Observer 
  {

    public string? Name { get; set; } = "OBS STUDIO";

    public event EventHandler? OnObserver;

    public void RaiseEvent() => OnObserver?.Invoke(this, EventArgs.Empty);

  }
```

**EventHandle<TEventArgs>** - Representa um metodo que vai manipular  um evento que possui dados.

```cs
  // TEventargs e o tipo do dado gerado no evento.
  // sender contem referencia ao objeto que gerou o evento.
  // e possui metadados do evento.
  public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
```

Para usar o EventHandler passando dados para os inscritos, eu posso  criar uma classe
que herdar de **EventArgs** ou eu posso alterar o generic do EventHandler para um tipo que eu quero.

```cs

  class Dados: EventArgs 
  {
    public string? Conteudo { get; set; }

  }
```

```cs

  class Inscrito
  {
    
    public static void Receber(object? sender, Dados d) 
    {
      Console.WriteLine(d.Conteudo);
    }

  }
```


# Metodos de Extensao

 método de extensão em C# permite que você adicione novos métodos a uma classe existente sem modificar diretamente a classe. Isso é especialmente útil quando você deseja estender a funcionalidade de uma classe sem ter acesso ao código-fonte da classe ou sem desejar criar uma nova subclasse.

 Basicamente isso é como se fosse @types do Typescript onde conseguimos sobrescrever um tipo
colocando mais atributos.

```cs
  public static class StringExtensao
  {
    public static string Invert(this string v) // A palavra This indica que uma extensao para o tipo string
    {
      char[] charArray = v.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
  } 
```

```cs
  using namespaceStringExtensao;

  string v = "dsadas".Invert(); /// Usando o metodo extendido.
```

# LINQ - Language Integrated Query

É um conjunto de tecnologias baseadas na integração de recursos de consulta diretamente na linguagem C#. Ela permite escrever consultas em coleções fortemente tipadas usando 
palavras-chaves da linguagem C#, operadores familiares e com o suporte ao IntelliSense.

Ela fornece uma sintaxe baseada na escrita de SQL, podendo utilizar ela para 
manipular dados de objetos, banco de dados relacionais, XML e diversas outras fontes de dados.

**System.Linq**

As consultas LIQN retorna resultados como objetos. Ela usa metodod e extensao para
classes que implementam a interface IEnumerable ou IQueryable. Ou seja, podemos
chamar os metodos da LINQ em qualquer objeto que implemente IEnumerable e IQueryable.

Resumindo o Linq e como o JPQL.

**Query Syntax (Sintaxe de Consulta)** - É escrito usando uma sintaxe semelhante ao SQL. Com palavras chaves select, from, where, group by, order by, etc.

```cs
  from object in DataSource
  where condition
  select obj;

```

**Method Syntax (Sintaxe de método)** - 

```cs
  nomes.Where(m => m.Contains('o'));
```

Então é possível utilizar as duas abordagens para fazer consulta, a Method Sintax é mais inxuta.

As operações feitas nas consultas são tratadas como Lazy e só são efetuadas de fato quando são chamadas com métodos como ForEach, Count, Sum, ToList, etc.

# Operadores de consulta padrao: System.Linq.Enumerable e Queryable 

**Filtro** - Where, OfType

**Ordenacao** - OrderBy, OrderByDesceding, ThenBy, ThenByDescending, Reverse

**Agrupamento** - GroupBy, ToLookup

**Juncao** - GroupJoin, Join

**Projecao** - Select, SelectMany

**Agregacao** - Aggregate, Average, Count, LongCount, Max, Min, Sum

**Quantifiers** - All, Any, Contains

**Elementos** - ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault

**Set** - Dinstict, Except, Intersect, Union

**Particionamento** - Skip, SkipWhile, Take, TakeWhile

**Concatenacao** - Concat

**Equality** - SequenceEqual

**Geracao** - DefaultEmpty, Empty, Range, Repeat

**Conversao** - AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList
