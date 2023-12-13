Console.WriteLine("## Instrução for ##\n");

//-----------------------------------------------------
// multiplas expressões na inicialização e iteração
//-----------------------------------------------------

Console.WriteLine("## loop for ##\n");

for(int i = 0, j=0; i+j <= 20; i++,j++ )
{
    Console.WriteLine($"i= {i} e i={j}");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//------------------------
// loop for seções opcionais
//-------------------------

int i = 1;
for(;i<=10;)
{
    Console.WriteLine($"i= {i}");
    i++;
}
Console.ReadKey();


//--------------------
// loop infinito
//--------------------
int j = 1;
for (;;)
{
    Console.WriteLine($"j = {j}");
    j++;
}
Console.ReadKey();

//------------------------
// loop for aninhado
//-------------------------

for (int x=0; x<5; x++)
{
    for(int y=0; y<5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();    
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
