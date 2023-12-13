
using _17ProblemasHeranca;

ComportamentoAndar andar = new ComportamentoAndar();
ComportamentoNadar nadar = new ComportamentoNadar();

var homem = new Homem(andar);
homem.Locomocao();

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();


Console.ReadKey();