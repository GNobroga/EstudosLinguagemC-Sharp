# Arquivos, Diretorios e Streams.

Algumas das classes para trabalhar com arquivos.

**File** - Namespace System.IO

E uma classe com metodos estaticos

```cs
  //Methods: Create, Delete, Exists, Copy, Move <- 
  //Methods:  ReadAllText, ReadAllBytes, WriteAllText, WriteAllBytes, AppendAllText
  //Methods:  ReadAllLines, GetLastWriteTime, GetLastAccessTime


  // Criar arquivo
  //File.Create(path);

  File.WriteAllText(path, "conteudo....");


```

**FileInfo** - Namespace System.IO

E uma classe que precisa ser instanciada.

**Directory**

Classe estatica pra manipular diretorios

**DirectoryInfo**

Classe nao estatica pra manipular diretorios

**Path**

Classe para informacoes do caminho

**FileStream**

Um stream e fluxo de dados que podem ser lidos em partes. Tem isso no JavaScript.

**StreamReader**

Muito semelhante ao BufferedReader do Java

Serve pra ler de Stream, pra usa-la primeiro preciso criar um FileStream.

**StreamWriter**

Serve pra escrever em Stream, pra usa-la primeiro preciso criar um FileStream.

Muito semelhante ao BufferedWriter do Java

# String verbatim para manter a formatacao da string

```cs
  string path = @"C:/dir/dir/file.txt";
```

# Acessar variaveis de ambiente

```cs
  Environment.NewLine;
```

# Bloco using para abrir e fechar arquivo automaticamente

Muito semelhante o Try-Catch-Resourcers do Java, que abre e fecha 
arquivos.

```cs
  using (FileStream fs = new FileStream(path, FileMode.Open))
  {
    // Operacoes
  }
```

ou 

```cs
 using FileStream fs = new FileStream(path, FileMode.Open);
```

# Verificar null

```cs
  string nome = null;

  if (nome is null || nome is not null) 
  {
    Console.WriteLine("OK");
  }
```