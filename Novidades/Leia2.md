# Required Members

Permite adicionar o modificador **required** nas propriedades e campos para forçar o construtor inicializar seus valores na criação de novas instância do objeto.

```cs
  public class Pessoa
  {
    public required string? Nome { get; set; } // O required obriga setar o valor de Nome, mesmo chamando o construtor Padrao.
  }
```

# Files scoped types

O modificador **file** permite criar um tipo cuja visibilidade tem como escôpo o arquivo no qual ele foi declarado. Eu nao consigo acessar essa classe em outro arquivo.

```cs
  file class PessoaIdentidade
  {
    public int GetCPF => 123423; // => Criar uma propriedade somente leitura com valor iniciado.
  }
```

# Extended nameof scope

Podemos usar nameof dentro de anotacoes, metodos, etc agora.
O nameof pega o nome da variavel.

```cs
  [MeuAtributo(nameof(meuParametro))]
  public void MeuMetodoComParametros(string meuParametro)
  {

  }
```

# Generic attributes (Anotações)

Podemos declarar uma classe generica cuja classe base é **Attribute**. Esse
recurso fornece uma sintaxe mais conveniente para atributos que requrem um parâmetro **Type**.


Atributos são sememelhantes a anotação do Java.

Jeito antigo

```cs
  public class MeuAtributo : Attribute
  {
    public MeuAtributo(Type t) => ParamType = t;

    public Type ParamType { get; }
  }

  public class Pessoa
  {
    public string? Nome { get; set; }

    [MeuAtributo(typeof(string))] //antes do C# 11
    public string MeuMetodo() => default; 
  }
```

Jeito novo

```cs
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  public class CustomAttribute<T> : Attribute
  {
      public T Value { get; set; }

      public CustomAttribute(T value)
      {
          Value = value;
      }
  }

  [CustomAttribute<int>(123)]
  class MinhaClasse
  {
      [CustomAttribute<string>("Custom")]
      public void MeuMetodo()
      {
          // Método personalizado
      }
  }
```

# Uso do typeof

O typeof serve para obter um objeto System.Type que representa um tipo especifico.