namespace CuentasBancarias;

public class CuentaBancaria
{
    private decimal _saldo;

    public void Depositar(decimal monto)
    {
        _saldo += monto;
    }

    public decimal ConsultarSaldo()
    {
        return _saldo;
    }
}