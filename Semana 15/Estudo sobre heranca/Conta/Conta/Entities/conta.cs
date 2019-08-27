namespace Conta.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string TitularConta { get; private set; }
        public double Saldo { get; protected set; } //a subclasse tera acesso a variavel

        public Conta()
        {
        }

        public Conta(int numero, string titularConta, double saldo)
        {
            Numero = numero;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

    }
}
