
MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Olá, multicasta delegate!");

delegateMulticast -= Metodo3;
delegateMulticast("O Metodo3 foi removido...");

Console.ReadKey();
static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}
static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);
