Console.WriteLine("### Programação Síncrona ###\n");

int espera = 4000;//representa 4000 milisegundos ou 4 segundos

Console.WriteLine("Tecle algo para iniciar");
Console.ReadLine();

RealizarTarefa(espera); //chama o método 

Console.WriteLine($"\nTempo gasto {espera / 1000} segundos");
Console.WriteLine("\n###Fim do processamento");

Console.ReadKey();

static void RealizarTarefa(int tempo)
{
    Console.WriteLine("\n>>>Iniciando a tarefa...");
    //Task.Delay(TimeSpan.FromMilliseconds(tempo));
    Thread.Sleep(tempo);
    Console.WriteLine(">>>Tarefa concluida.");
}