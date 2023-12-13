namespace _17ProblemasHeranca;

/* 
    **nameof** - Pega o nome da Classe em formato de string.

    nameof(Product) = Product
*/
public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco(ComportamentoAndar comportamentoAndar)
    {
        _comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
