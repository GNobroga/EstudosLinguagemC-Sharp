# Tratamento de Excecoes 

Todos os erros herdam de Exception

Existem duas principais classes que herdam de **Exception**,
**SystemException** e **ApplicationException**.

          Object

          Exception
SystemException   ApplicationException

Os erros geradores pelas bibliotecas do **.NET** sao provenientes 
das subclasses que herdam de **SystemException**.


# Informacoes

**Message**

**StackTrace**

**InnerException**

**Source**

**HelpLink**

# Filtros de Exception

Podemos adicionar filtros com a palavra chave **when**.

O bloco catch so sera executado quando a condicao for verdadeira.
Se a condicao for falso ele procura pelo proximo catch. Caso nao encontre
vai lancar a exception normalmente.

```cs
  try 
  {

  }
  catch (Exception e) when (Criterio)
  {

  }
  
```