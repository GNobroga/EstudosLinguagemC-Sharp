
// Operador permite adiciona operacoes em um tipo, exemplo pode somar um tipo com outro, subtrair etc

var p1 = new Product { Price = 10 };
var p2 = new Product { Price = 10 };

var p3 = p1 + p2;

Console.WriteLine(p3.Price);




public class Product 
{
    public double Price { get; set; }

    public static Product operator +(Product x, Product y) 
    {
        return new Product { Price = x.Price * x.Price };
    }

}