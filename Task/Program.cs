
var t1 = Task.Factory.StartNew(() => ShowAt("Thread 1", 10));
Console.WriteLine("Tasks started"); 
var t2 = Task.Factory.StartNew(() => ShowAt("Thread 2", 10));

var tasks = Task.WhenAll(t1, t2);
await tasks;
Console.ReadKey();

var delay = Task.Delay(23);


void ShowAt(string name, int max) 
{
    Console.WriteLine();
    for (int i = 0 ; i < max ; i++)
    {   
        Console.WriteLine($"Tarefa {name} {i}");
        Task.Delay(100);
    }
}


