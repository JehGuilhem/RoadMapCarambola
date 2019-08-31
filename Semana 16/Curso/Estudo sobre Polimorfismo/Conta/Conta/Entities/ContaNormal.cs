namespace Conta.Entities
{
    class ContaNormal
    {
        public int Numero { get; private set; }
        public string TitularConta { get; private set; }
        public double Saldo { get; protected set; } //a subclasse tera acesso a variavel

        public ContaNormal()
        {
        }
        public ContaNormal(int numero, string titularConta, double saldo)
        {
            Numero = numero;
            TitularConta = titularConta;
            Saldo = saldo;
        }
        //virtual para declarar que ele pode ser sobrescrito na subclasse
        public virtual void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

    }
}
