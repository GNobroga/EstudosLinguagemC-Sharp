using _18Enumeration;

Console.WriteLine("## Enum ##\n");

Console.WriteLine($"{DiasDaSemana.Domingo} - {(int)DiasDaSemana.Domingo}");
Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("\nSelecione a Categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria : {nomeMembroEnum.ToString()}");




BasicColor c;
c = BasicColor.red;
Console.WriteLine(c);

Console.ReadKey();

enum BasicColor
{
    red,
    green,
    blue
}