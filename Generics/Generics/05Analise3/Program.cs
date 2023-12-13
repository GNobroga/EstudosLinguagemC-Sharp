ClasseGenerica<int> obj1 = new ClasseGenerica<int>();
obj1.Adicionar(50);

ClasseGenerica<string> obj2 = new ClasseGenerica<string>();
obj2.Adicionar("Generics");

ClasseGenerica<Aluno> obj3 = new ClasseGenerica<Aluno>();
obj3.Adicionar(new Aluno { Nome = "Generics" });

//Análise da reutilização de código

// Uma classe Genérica pode ser definida uma única vez e pode ser
// instanciada de muitas maneiras diferentes, podendo inclusive,
// ser definida em uma linguagem da plataforma .NET e ser usada
// por outra linguagem.

// Assim, no nosso exemplo, podemos instanciar a classe ClasseGenerica<T>
// com tipos int , string e também usar um tipo definido pelo usuário
// como uma classe Aluno:

Console.ReadKey();
public class ClasseGenerica<T>
{
    //definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    //adicionar elementos
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }
    //indexador para a iteração da instrução foreach
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
public class Aluno
{
    public string? Nome { get; set; }
}
