
namespace Conta.Entities
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titularConta, double saldo, double taxaJuros)
            : base (numero, titularConta, saldo)
        {
            TaxaJuros = taxaJuros;
        } 

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
