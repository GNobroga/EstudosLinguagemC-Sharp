using _14Interfaces_ImplementacaoExplicita;

Forma forma = new Forma();
//forma.Desenhar();

IControle controle = forma;
IGrafico grafico = forma;
controle.Desenhar();
grafico.Desenhar();

Console.ReadKey();