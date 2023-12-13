namespace Novidades.VerificaNull;

public class Null 
{

  static string Juntar(string a, string b) 
  {
    // Permite verificar se elementos sao null, se forem uma exececao sera lancada.
    ArgumentNullException.ThrowIfNull(a);
    ArgumentNullException.ThrowIfNull(b);

    return a + b;
  }
}