using _15Composicao;

var logger = new Logger();

var migrador = new Migrador(logger);
migrador.DataHora = DateTime.Now;
migrador.Migrar();

var instalador = new Instalador(logger);
instalador.DataHora = DateTime.Now;
instalador.Local = "c:\\demo";
instalador.Instalar("Programa A");

instalador.DataHora = DateTime.Now;
instalador.Local = "c:\\teste";
instalador.Instalar("programa B");

Console.ReadKey();