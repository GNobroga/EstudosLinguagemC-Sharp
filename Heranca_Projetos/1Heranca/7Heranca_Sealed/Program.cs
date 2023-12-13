/*
    O Sealed serve para impedir que outras classes herdem da classe.
    Alem disso, eu tambem posso usar o sealed em metodos para impedir
    que outras classes que herdarem sobscrevam o metodo.
*/
Cliente cli = new();
//cli.Nome = "Manoel";
cli.ExibeNome();

Console.ReadKey();

//sealed inibe a herança
sealed class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente : Pessoa
{
    public new void ExibeNome()
    {
        //Console.WriteLine($"\nNome do cliente : {Nome}");
    }
}

//================usando sealed em metodos ========================
class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }

}

class Classe2 : Classe1
{
    // Tentar sobrescrever Metodo1() causa um erro CS0239.  
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }
}