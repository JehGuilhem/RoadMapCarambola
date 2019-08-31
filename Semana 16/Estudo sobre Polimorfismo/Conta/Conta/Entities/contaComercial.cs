
namespace Conta.Entities
{
    class ContaComercial : ContaNormal
    {
        public double LimiteEmprestimo { get; set; }

        public ContaComercial()
        {
        }
        //construtor da subclasse
        public ContaComercial(int numero, string titularConta, double saldo, double limiteEmprestimo) 
            : base(numero, titularConta, saldo) // aproveitando o contrutor da classe conta
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo (double quantia)
        {
            if (quantia <= LimiteEmprestimo)
                Saldo += quantia;
        }

    }
}
