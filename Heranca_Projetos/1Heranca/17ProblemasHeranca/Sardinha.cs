namespace _17ProblemasHeranca;

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _comportamentoNadar = comportamentoNadar;
    }

    public void Locomocao()
    {
        Console.Write(nameof(Sardinha));
        _comportamentoNadar.Nadar();
    }
}
