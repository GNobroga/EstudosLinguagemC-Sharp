namespace _9Heranca_UpcastingDowncasting;

public class Forma
{
    protected int xpos, ypos;
    
    public Forma()
    {}
    
    public Forma(int x, int y)
    {
        xpos= x;
        ypos= y;    
    }

    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição : ({xpos},{ypos})");
    }
}
