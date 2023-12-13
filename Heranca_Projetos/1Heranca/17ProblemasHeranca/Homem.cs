namespace _17ProblemasHeranca;

public class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;
    public Homem(ComportamentoAndar andar)
    {
        _comportamentoAndar = andar;
    }
    public void Locomocao()
    {
        Console.Write(nameof(Homem));
        _comportamentoAndar.Andar();
    }
}
