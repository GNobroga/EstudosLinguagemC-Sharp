
# Programação Assíncrona 

Permite executar tarefas sem bloquear a outra.

Palavras chaves

**async** - Usado para indicar que um método pode ser executado de forma assíncrona.

**await** - É usado para esperar a conclusão de uma tarefa assíncrona.

Biblioteca **TPL (Task Parallel Library)** do .NET

É implementada usando a  classe Task do namespace **System.Threading.Tasks**,
a Task representa uma operação assíncrona.

## Retornos de métodos assíncronos 

**Task ou Task<T>** - E o tipo de retorno padrao para um metodo assincrono que nao retorna nenhum valor.

```cs
  public async Task MeuMetodoAsync()
  {
    // Simula uma operacao assincrona que leva 1s para ser concluida
    await Task.Delay(1000);
    Console.WriteLine("A opercao assincrona foi concluida");
  }

  await MeuMetodoAsync();
```
Forma numero 2

```cs
  public async Task<int> MeuMetodoAsync()
  {
    // Simula uma operacao assincrona que leva 1s para ser concluida
    await Task.Delay(1000);
    Console.WriteLine("A opercao assincrona foi concluida");
  }

  await MeuMetodoAsync();
```
Assim como no JavaScript o Task é uma Promise.

**ValueTask ou ValueTask<T>** - Fornece um resultado esperado de uma operação assíncrona. A diferença deles para o Task é que eles são tipo valor e não referência igual o Task. Eles tem o desempenho melhor. E util usar ValueTask quando a operacao for uma operacao rapida.

```cs
  public async ValueTask MeuMetodoAsync()
  {
    // Simula uma operacao assincrona que leva 1s para ser concluida
    await Task.Delay(1000);
    Console.WriteLine("A opercao assincrona foi concluida");
  }

  await MeuMetodoAsync();
```
Forma dois 

```cs
  public async ValueTask<int> MeuMetodoAsync(int num1, int num2)
  {
    if (num1 == 0 && num2 == 0) 
    {
      return 0;
    }
    return await Task.Run(() => num1 + num2 );
  }

  var sum =  MeuMetodoAsync(1, 2).Result // O Result bloqueia a Thread ate a operacao acabar, entao se for uma operacao sincrona vai certo bom usar ele.
```

**void**


# Programação Paralela

Executar várias tarefas ao mesmo tempo.

Biblioteca **Parallel** do .NET

# Cancelamento de tarefas

**Task.Run** - Enfileira o trabalho especificado para execucao e retorna uma Task.

```cs
  Task task = Task.Run(() => {
    
    for (int i = 0; i < 5 ; i++) 
    {
      Task.Delay(1000).Wait();
    }
  });


  task.Wait() // E como se fosse o then
```

## Tipo usados para realizar o Cancelamento

No JavaScript tem o AbortController que serve para cancelar um
fetch que assincrono. O conceito e o mesmo aqui para Task. Utilizamos o 
**CancellationToken** para cancelar uma Tarefa.

**CancellationTokenSource** - Isso permite obter o Token para setar no CancellationToken e cancelar uma tarefa.

**CancellationToken**

**OperationCanceledException**


# Dica rapida

Ao usar o static em uma class dessa forma, ela fica restrita a apenas ter metodos estaticos e nao podera ser **instaciada.**

```cs
  static class P 
  {

  }
```

# Tratamento de Execeções na Programação Assíncrona

Funções assincronas que retorna um Task ou Task, contém a execeção lançada no **Task.Exception**
que pode ser capturas com o **AggregateException**, essa classe herda de Exception e tem uma propriedade que se chamaa **InnerExceptions** que retorna um Array das execeções capturadas dos métodos assincronos.

Já métodos assincronos com retorno void
o tratamento tem que ser feito dentro da função. Além disso, a Task só vai lançar execeção se eu
colocar o **await**.


# Recomedacoes 

Só devemos usar programação assincrona quando precisamos de realizar tarefas em segundo plano (requisições, leitura de arquivos, etc).

**WhenAll** -> Para aguardar varias tasks
