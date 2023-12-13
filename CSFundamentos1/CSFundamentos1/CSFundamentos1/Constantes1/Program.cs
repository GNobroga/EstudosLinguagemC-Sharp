Console.WriteLine("## Constantes ##\n");

//declaração e inicialização de constantes
const int ANO = 12;
const int MES = 30, SEMANA = 7, QUINZENA = 15;
const int MESESANO = 12;
const int DIASANO = 365;

const float DIASPORMES = (float)DIASANO / (float)MESESANO;

//calculo da area e perimtro do circulo

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();

