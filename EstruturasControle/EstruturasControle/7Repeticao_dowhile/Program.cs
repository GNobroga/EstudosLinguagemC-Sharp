Console.WriteLine("## instrução do-while ##\n");

var i = 1;
do
{
    Console.WriteLine($"i = {i} ");
    i++;
}
while (i <= 10);

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

//---------------------------------------------------
// usando instrução break para sair do loop
// --------------------------------------------------
var j = 1;
do
{
    Console.WriteLine($"j = {j} ");
    j++;

    if (j > 7)
        break;
}
while (j <= 10);

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

//---------------------------------------------------
// loop do while aninhado
//-----------------------------------------------------
int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y})  ");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);

Console.WriteLine("Fim do processamento...");
Console.ReadKey();


