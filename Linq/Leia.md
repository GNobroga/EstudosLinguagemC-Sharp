# Linq

Language-Integrated Query é um poderoso conjunto de tecnologias baseado na integração de recuross de consulta na linguagem C#.

Ela fornece uma expêriencia de consulta consistente para consultar objetos, bancos de dados relacionas, XML, entidades e outras fontes de dados.

Ela oferece vários provedores para manipular cada tipo de fonte de dados.

Ela retorna objetos como resposta das consultas.

A Linq usa métodos extendidos em cima de classes que implementam IEnumerable ou IQueryable.

## Linq methods

**Filtering** - Filtragem
    Where
    Take - Retorna N elementos da colecao.

```cs
    int[] values = {1,2,3,4,5};
    values.Take(2); // Pega dois elementos 
```
    Skip - Ele pula alguns elementos de uma sequencia

```cs
    int[] values = {1,2,3,4,5};
    values.Skip(2); // Pega 3 4 5
```

    TakeWhile - Retorna elementos de uma sequencia desde que a condicao seja atendida. Porem, se ele encontrar 1 elemento que nao atenda a condicao ele para, diferente do Where.

 ```cs
    int[] values = {1,2,3,4,5};
    values.TakeWhile(n => num < 3); // Pega os menores que 2
```   
    SkipWhile - Pula elementos com base em uma condicao, se a primeira condicao for falsa
    ele para.

```cs
    int[] values = {1,2,3,4,5};
    values.SkipWhile(x => x > 2); // Pega 3 4 5
```


**Projecting**

    Select -> Semelhante ao Map do Javascript.

    SelectMany -> Semelhante ao flatMap do JavaScript.

**Joining**  - Faz uniao entre fontes de dados 

    Join - Retorna as colecoes juntadas. // join c in colecoes on x equals y;

```cs
    funcionarios.Join(setores, funcionario => funcionario.Setor_Id, setor => setor.SetorId, (funcionario, setor) => new { FuncName = "dsds", SetorName = "sdsd"});

    var innerJoin = from f in funcionarios join s in setores 
        on f.Setor equals s.SetorId select new { Nome = "dsds" };

```

    GroupJoin - Une duas colecoes e agrupa. Ela e bom pra agrupar dados de um relacao M x N.

```cs
    var groupJoin = setores.GroupJoin(funcionarios, s => s.SetorId, f =>  f.SetorId, (s, fGrupo) => new { Nome = "sdsd"});
```

    Zip

**Ordering**

    OrderBy - Usado para classificar os dados em ordem crescente.

```cs
    lista1.OrderBy(x => x.Property);
```

    OrderByDescending - Classifica em ordem descrescente.

```cs
    lista1.OrderBy(x => x.Property);
```

    ThenBy - Permite adicionar mais criterios de ordenacao no OrderBy, ou seja ordernar pelo Id
    e Nome. OrderBy

```cs
    lista1.OrderBy(x => x.Property1).ThenBy(x => x.Property2);
```

    ThenByDescending - Permite adicionar mais criterios de ordenacao no OrderBy, ou seja ordernar pelo Id
    e Nome. Usado com OrderByDesceding.

    Reverse - Ele retorna os elementos ao contrario. Em Iteravel de string e necessario converter
    para IEnumerable.

```cs
    int[] values = {1,2,3,4,5};
    values.Reverse(); // 5 4 3 2 1
```

**Grouping**  
    GroupBy - Agrupa valores iguais, retorna uma matriz.


```cs
    var grupos = from v in values group v by v.idade; // Usando Linq Consult
```

**Conversion** - Serve para converter IEnumerable para uma Collectin
    ToArray

```cs
    List<int> alunos = new() {1, 2, 3}; 
    alunos.AsEnumerable();
```

    ToList 

```cs
    alunos.ToList();
```

    ToDictionary

```cs
    alunos.ToDictionary<Key, Value>(a => a.Id);
```
    ToLookup - Semelhante ao Dictionary, mas mapeia para uma colecao de valores

```cs
    alunos.ToDictionary<Source, Key, Value>(a => a.Id);
```

    AsEnumerable - Converter Colecao para Enumerable

    AsQueryable - Converter Colecao para Queryable

    Cast - Tenta converter todos os itens de uma colecao em um outro tipo e retorna a sequencia convertida.

```cs
    List<object> dados = new List<object>() { "Tania", 50, 60, true };

    var resultado = dados.Cast<int>(); // Vai gerar error, porque apenas alguns sao inteiros.

```

    OfType - Serve para filtrar elementos de tipo especifico

```cs
    List<object> dados = new List<object>() { "Tania", 50, 60, true };

    var dadosInt = dados.OfType<int>().ToList(); // Pega somente os do tipo int;
```

**Set** - Concat, Union, Except, Intersect

**Element** - Sao usados para retornar um unico elmento de uma fonte de dados usando o indice do elemento ou com base em um predicado.

    ElementAt  - Retorna o elemento presente na posicao de indice da fonte dados  ou no valor do indice baaseado em zero.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.ElementAt(0);
```
    ElementAtOrDefault - Se nao encontrar o elemento ele retorna um valor padrao, pois o ElementAt lanca excecao caso nao encontre.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.ElementAtOrDefault(0);
```

    Single

    Last
    
    First - Pega o primeiro elemento que atenda um condicao // Retorna Exececao caso nao encontre.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.First(x => x == 3);
```
    FirstOrDefault - Nao retorna excecao caso nao encontre.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.FirstOrDefault(x => x == 3);
```

    Last - Retorna o ultimo elemento baseado em um predicate. // Lanca excecao

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.Last(x => x == 3);
```
    LastOrDefault - Nao lanca excecao.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.LastOrDefault(x => x == 3);
```
    Single - Verifica se tem um elemento com o criterio definido, se tiver varios ou nao tiver 1
    ele lanca uma exececao.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.Single(n => n => 10);
```
    SingleOrDefault - Faz a mesma coisa, mas nao lanca excecao. Mas se tiver mais de 1 elemento igual que atenda a condicao ele vai retornar.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.SingleOrDefault(n => n => 10);
```
    DefaultIfEmpty - Se a colecao for vazia, ele retorna o valor padrao.

```cs
    int[] numeros = {1, 2, 3, 4};
    int resultado = numeros.DefaultIfEmpty() // 1 2 3 4; 

    int[] numeros = {};
    int resultado = numeros.DefaultIfEmpty() // Retornara 0 porque e o valor padrao e int; 

    int[] numeros = {};
    int resultado = numeros.DefaultIfEmpty(100) // Retornara 100 porque a lista ta vazia e o valor padrao agora e 100.
```

**Aggregation** 

 Min/MinBy - Determina o valor minimo da colecao.

 Max/MaxBy - Determina o valor maximo da colecao.

 Sum - Calcula a soma dos valores em uma colecao.

 Count - Conta os elementos em uma colecao.

 Average - Calcula a media dos itens numericos em uma colecao.
 
 Aggregate - Pega uma colecao e a saida e um unico valor.

**Quantifiers** 
    SequenceEqual
    Contains - Determina se a fonte de dados contem um elemento especifico.
    Any - Determina se um dos elementos da fonte de dados satisfaz uma condicao.
    All - Determina se todos os elementos da fonte de dados satisfaz uma condicao.

**Generation** - Geram uma sequencia de valores

    Empty - Retorna uma colecao vazia.

```cs
    Enumarable.Empty<string>() // retorna uma sequencia vazia.
```


    Range - Gera uma colecao que contem uma sequencia de numeros.

```cs
    Enumarable.Range(1, 10) // vai comecar do 1 e vai ate 10
```

    Repeat - Gera uma colecao que contem valor repetido.

```cs
    Enumarable.Range("Cu", 10) // vai repetir cu  10 vezes 
```


**Conjunction**

    Distinct/DistinctBy -> Remove os valores duplicados de uma colecao. O DistinctBy permite escolher o atributo que vai ser o alvo em casos de objeto.

    Except/ExceptBy - Retorna a diferenca de conjunto, ou seja, os elementos de uma colecao
    que nao aparecem em uma segunda colecao. O ExceptBy permite escolher o atributo alvo m casos de objeto.

    Lista 1: 1 2 3 4 5 6
    Lista 2: 1 3 5 8 9 10
    Output: 2 4 6

```cs

fonte1.Except(fonte2).ToList();
```

    Intersect/IntersectBy - Retorna a intersecao de conjunto, ou seja, os elementos que
    aparecem em cada uma das duas colecoes. O IntersectBy permite selecionar o atributo alvo em casos de objeto.

```cs
    string[] font1 = {"Brasil", "USA", "UK"};
    string[] font2 = {"Brasil", "UK"};

    font1.Intersect(font2).ToList(); // Brasil Uk

    font1.Select(x => x.Nota).Intersect(font2.Select(x => x.Nota)); // Retorna intercecao
```

    Union/UnionBy - Retorna a uniao de conjunto, ou seja, os elementos unicos que aparecem em qualquer uma das duas colecoes. O IntersectBy permite selecionar o atributo alvo em casos de objeto.

    Lista 1: 1 2 3 4 5 6

    Lista 2: 1 3 5 8 9 10

    Saida: 1 2 3 4 5 6 8 9 10

**Outros** 

    Append - Usado para adicionar no final da sequencia, criar uma nova copia da sequencia com o valor acrescentado no fim.

```cs
    List<int> numeros = new List<int> { 1, 2, 3 , 4};
    var novos = numeros.Append(10);
```

    Prepend - Usado para adicionar no inicio da sequencia.

```cs
    List<int> numeros = new List<int> { 1, 2, 3 , 4};
    var novos = numeros.Prepend(10);
```
    Zip - Usado para aplicar uma funcao especifica aos elementos correspondentes de duas sequencias e produzir uma sequencia com os resultados. Semelhante do zip do Python.

```cs
    List<int> numeros = new List<int> { 1, 2, 3 , 4};
    List<string> palavras = new List<string> {"1", "2", "3" , "4"};
    var resultado = numeros.Zip(palavras, (prim, seg) => prim + " " + " " + seg);
    // 1 1
    // 2 2
    // 3 3
    // 4 4
```

**Include**  - Para incluir uma entidade com ligacao.

**AsNoTracking**


# IEnumerable

Ele garante que uma classe seja iteravel, ou seja, e o Iterator do Java.

**IEnumerable** é uma interface que define um método que permite a iteração sobre uma coleção genérica.
Ela é usada para trabalhar com coleções de objetos em memória.
As consultas em IEnumerable são realizadas em memória, o que significa que todos os dados são recuperados do banco de dados e, em seguida, a filtragem é feita na memória do aplicativo.
Isso é apropriado quando você deseja trabalhar com dados em memória e quando não precisa de operações de consulta complexas ou otimizações de banco de dados.
IQueryable:

**IQueryable** é uma interface que estende IEnumerable e permite a execução de consultas em fontes de dados remotas, como bancos de dados SQL.
Ela permite que você escreva consultas em um idioma específico de consulta (por exemplo, SQL) que serão traduzidas e executadas no provedor de dados.
As consultas em IQueryable são executadas no servidor de banco de dados, o que permite a otimização de consulta e reduz a quantidade de dados transferidos pela rede.
Isso é útil quando você deseja executar consultas complexas ou pesadas em bancos de dados remotos.
