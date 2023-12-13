# Global using

Permite importar uma única vez um pacote, usando a palavra **global**.

Desse modo, eu posso importar um namespace que ficará disponível para toda a aplicação sem precisar redeclarar em cada arquivo.

```cs
  global using System;
  global using System.Collections;
```

# Implicit using 

Remover namespaces que foram incluídos via implicit usings em seu arquivo de projeto

```cs
  <ItemGroup>
    <Using Remove="System.Threading>Tasks">
  </ItemGroup>
```

Adicionar namespace usando diretivas globais em seu arquivo de projeto

```cs
  <ItemGroup>
    <Using include="System.IO.Pipes">
  </ItemGroup>
```

# Scoped Namespaces

Antigamente eu podia fazer assim pra declarar um namespace;

```cs
  namespace Name
  {
    public class Produto
    {
      public string Nome { get; set; }
    }
  }
```

Agora eu posso fazer assim

```cs
  namespace Name;
  
  public class Produto
  {
    public string Nome { get; set; }
  }
  
```

# Recursos novos para lambdas

A partir do C# 10 o compilador consegue inferir sobre expressões lambdas.

Forma antiga

```cs
  Func<string, int> parse = s => int.Parse(s);  
```

Forma nova

```cs
  var parse = (string s) => int.Parse(s);
```

## Tipo de retorno em lambdas

Permite especificar um tipo de retorno explicito em uma expressao lambda.

```cs
  var escolha = object (bool b) => b ? 1 : 0;
```

## Atributos em lambdas

Agora é permitido colocar anotações em funções lambdas. Isso pode servir como metadados.
Antigo 

```cs
  Func<string, int> parse = [Exemplo(1)] (s) => int.Parse(s);

```

Novo 

```cs
  var escolha = [Exemplo(2)][Exemplo(3)] object (bool b) => b ? 1 : 0;
```

Para usar os atributos usa-se a criação de decoração com **AttributeTargets.Method**.


# Datas

**DateTime** - Representa um momento expresso como uma data e hora do dia.

```cs
  DateTime datetime = new DateTime(); 01/01/0001 00:00:00
```

**DateOnly** - Representa so a data

```cs
  DateOnly dateOnly = new DateOnly(); 01/01/0001
```

**TimeOnly** - Representa so o tempo

```cs
  TimeOnly timeOnly = new TimeOnly(); 00:00:00
```


# Novidades 2

Definindo literal de string, funciona igual ao @"fsdfds";

```cs
  var text = """
    dsdsdasd
  """;
```

**Interpolacao** - Usando $ ou $$

Com o uso de apenas um **$** ele vai tratar {} como sendo um interpolacao, com
**$$** ele so vai tratar interpolacao com {{}};

```cs
  var result1 = $"""21 + 34 = {21 + 34}"""; // 21 + 34 = 55

  var result2 = $$"""{21 + 34} = {{21 + 34}}"""; // {21 + 34} = 55
```

# Correspondencia de padroes de lista

O **is** verifica uma correspondencia, no primeiro caso verifica se 1 ta na primeira posicao e
no segundo se o 3 esta na 4.
```cs
  int[] numeros = {1, 2, 3, 4, 5};

  bool resultado = false;

  resultado = numeros is [1,_, _, _, _]; // true

  resultado = numeros is [_,_, _, 3, _]; // false
```

# Sequencia de valores (Array, List)

**(Discard Pattern) ou Padrão Descartar**

_ Esse operador pode ser usado para referenciar um unico elemento.

**(Range pattern) ou Padrão de intervalo**

.. Esse operador permite referenciar varios elementos.

**Capturar o valor de um sequencia de valores**

```cs
  int[] v = {1, 2, 3, 4, 5, 8};
  if (v is [.., var penultimo, var ultimo]) 
  {
    Console.WriteLine("SIM")
  }
   
```