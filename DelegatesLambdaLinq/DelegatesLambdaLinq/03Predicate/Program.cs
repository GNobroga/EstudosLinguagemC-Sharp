
List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomeNaLista);

string resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();