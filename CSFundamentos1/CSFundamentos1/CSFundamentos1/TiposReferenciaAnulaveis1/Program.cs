Console.WriteLine("## Tipos de referência Anuláveis ##\n");

// alerta do compilador ativado 
// no arquivo de projeto <Nullable>enable</Nullabe>
//string nome = null;

//inibe o alerta do compilador
string? nome = null;

// o operador null conditional operador(?.)
// impede o erro NullReferenceException
Console.WriteLine(nome?.ToUpper());

Console.ReadKey();
