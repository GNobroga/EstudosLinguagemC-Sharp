/*
    O **Virtual** serve para permitir sobrescrever um metodo na classe filha.
    A diferenca dele e do abstract e que ao usar o abstract eu sou 
    obrigado a declarar minha classe como sendo uma classe abstract.
    Enquanto, que usando o Virtual eu nao tenho essa necessidade.
*/


//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}
