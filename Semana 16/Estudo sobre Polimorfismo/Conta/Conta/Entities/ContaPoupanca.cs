
namespace Conta.Entities
{
    class ContaPoupanca : ContaNormal
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titularConta, double saldo, double taxaJuros)
            : base (numero, titularConta, saldo) // aproveitar o construtor da classe conta
        {
            TaxaJuros = taxaJuros;
        } 

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //reimplementa uma operacao que existe na super claase dentro da sub classe
        public override void Saque(double quantia)
        {
            base.Saque(quantia); // desconta o valor junto com o valor da taxa ba superclasse
            Saldo -= quantia;
        }
    }
}
