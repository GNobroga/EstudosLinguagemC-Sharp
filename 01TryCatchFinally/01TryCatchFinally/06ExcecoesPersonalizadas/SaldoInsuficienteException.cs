namespace _06ExcecoesPersonalizadas;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string? message)
        : base(message)
    { }
    public SaldoInsuficienteException(string? message, Exception? innerException)
        : base(message, innerException)
    { }

    public SaldoInsuficienteException(decimal saque, decimal saldo)
      : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
    { }

    public override string Message
    {
        get
        {
            return "\nNão existe saldo suficiente para o valor do saque";
        }
    }
    public override string HelpLink
    {
        get
        {
            return "Info: https://rb.gy/clgqbv";
        }
    }

}
