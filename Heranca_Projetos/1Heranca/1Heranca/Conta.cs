namespace _1Heranca;

public class Conta
{
    public int contador;
    public int Numero { get; set; }
    public decimal Saldo { get; set; }

    public decimal GetSaldo()
    {
        return Saldo;
    }
}
