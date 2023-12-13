using _02TaskProgAssincrona;

Console.WriteLine("### Café da manha Síncrono ###");
CafeDaManha();

Console.WriteLine("### Café da manha Assíncrono ###");
CafeDaManhaAsync();

Console.ReadKey();
static void CafeDaManha()
{
    Console.WriteLine("\n-- Preparar o café");
    var cafe = PrepararCafe();

    Console.WriteLine("\n** Preparar o pão");
    var pao = PrepararPao();

    ServirCafe(cafe, pao);
}
static async void CafeDaManhaAsync()
{
    Console.WriteLine("\n-- Preparar o café");
    var tarefaCafe = PrepararCafeAsync();

    Console.WriteLine("\n** Preparar o pão");
    var tarefaPao = PrepararPaoAsync();

   var cafe = await tarefaCafe;
   var pao = await tarefaPao;

    ServirCafe(cafe, pao);
}
static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n>>Servindo o cafe da manhã");
    Thread.Sleep(2000);
    Console.WriteLine(">>Café servido");
}

static Cafe PrepararCafe()
{
    Console.WriteLine("-Fervendo a água");
    Thread.Sleep(2000);
    Console.WriteLine("-Coando o café");
    Thread.Sleep(2500);
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}
static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("-Fervendo a água");
    await Task.Delay(2000);
    Console.WriteLine("-Coando o café");
    await Task.Delay(2500);
    Console.WriteLine("-Adoçando o café");
    return new Cafe();
}

static Pao PrepararPao()
{
    Console.WriteLine("*Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("*Passar manteiga no pão");
    Thread.Sleep(2000);
    Console.WriteLine("*Tostar o pão");
    return new Pao();
}

static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("*Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("*Passar manteiga no pão");
    await Task.Delay(2000);
    Console.WriteLine("*Tostar o pão");
    return new Pao();
}
