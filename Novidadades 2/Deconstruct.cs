
// Desestruturar
public class Ponto
{
    public int X { get; set; }
    public int Y { get; set; }

    // Deconstrutor
    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class Program
{
    static void Main()
    {
        Ponto ponto = new Ponto { X = 10, Y = 20 };

        // Desestruturação usando o deconstrutor
        var (x, y) = ponto;

        Console.WriteLine($"X: {x}, Y: {y}");
    }
}
