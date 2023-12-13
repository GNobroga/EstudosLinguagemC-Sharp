using _18Polimorfismo1;

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}


Console.ReadKey();