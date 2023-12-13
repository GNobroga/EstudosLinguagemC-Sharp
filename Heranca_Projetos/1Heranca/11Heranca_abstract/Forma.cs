namespace _11Heranca_abstract;

public abstract class Forma
{
    //propriedades
    public string? Cor { get; set; }
    public double Area { get; set; }    
    public double Perimetro { get; set; }

    //métodos abstratos
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    //método comum
    public string Descricao()
    {
        return "Sou a classe abstrata Forma";
    }
}
