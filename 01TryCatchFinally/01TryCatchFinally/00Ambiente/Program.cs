char[] letras = { 'J', 'o', 's', 'e', ' ', 'S', 'a', 'n', 't', 'o', 's' };

string nome = "";

int[] a = new int[11];

for (int i = 0; i < letras.Length; i++)
{
    nome += letras[i];
    a[i] = i + 1;
    EnviaMensagem(nome, a[i]);
}

Console.ReadKey();

static void EnviaMensagem(string nome, int indice)
{
    Console.WriteLine($"Olá {nome}  indice : {indice}");
}