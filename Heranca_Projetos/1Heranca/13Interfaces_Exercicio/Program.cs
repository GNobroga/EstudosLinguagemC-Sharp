
using _13Interfaces_Exercicio;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson= new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();



Console.ReadKey();