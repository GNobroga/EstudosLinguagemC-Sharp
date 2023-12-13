
// Switch Simplificado
var minhaTupla = (42, "Hello");

string resultado = minhaTupla switch
{
    (0, _) => "Primeiro elemento é 0",
    (_, "World") => "Segundo elemento é 'World'",
    (int numero, string texto) => $"Número: {numero}, Texto: {texto}",
    _ => "Padrão"
};

Console.WriteLine(resultado);



// Switch Expression
public readonly struct Point
{
    public Point(int x, int y) => (X, Y) = (x, y);
    
    public int X { get; }
    public int Y { get; }
}

static Point Transform(Point point) => point switch
{
    { X: 0, Y: 0 }                    => new Point(0, 0),
    { X: var x, Y: var y } when x < y => new Point(x + y, y),
    { X: var x, Y: var y } when x > y => new Point(x - y, y),
    { X: var x, Y: var y }            => new Point(2 * x, 2 * y),
};