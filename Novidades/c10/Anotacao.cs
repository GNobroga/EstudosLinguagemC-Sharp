namespace Novidades.Anotacao;

[MakeSomething("Nada")]
public class Derivative 
{

}
file class MakeSomething : Attribute 
{
  public string Phrase;

  public MakeSomething(string phrase) => Phrase = phrase;
}