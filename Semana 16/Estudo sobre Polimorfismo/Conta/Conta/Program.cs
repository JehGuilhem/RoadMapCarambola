using System;
using Conta.Entities;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe ContaNormal
            ContaNormal conta = new ContaNormal(1001, "Jeh", 500.0);
            //instanciando a classe ContaComercial
            ContaComercial contaComercia1 = new ContaComercial(1002, "Pedro", 0.0, 500.0);

            //POLIMORFISMO
            //objetos de um mesmo tipo tendo comportamentos diferentes

            //UPCASTING
            // recebe um objeto de qualquer tipo de sub classe dela
            ContaNormal conta1 = contaComercia1;
            ContaNormal conta2 = new ContaComercial(1003, "Luke", 0.0, 200.0);
            ContaNormal conta3 = new ContaPoupanca(1004, "Tank", 0.0, 0.01);

            //DOWNNCASTING
            //receber um objeto da super classe
            ContaComercial conta4 = (ContaComercial)conta2;
            conta4.Emprestimo(100.0);
            

            //Precisa falhar pois a conta3 nao pertence a ContaComercial
            if (conta3 is ContaComercial)
            {
                //ContaComercial conta5 = (ContaComercial)conta3;
                ContaComercial conta5 = conta3 as ContaComercial;
                conta5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if(conta3 is ContaPoupanca)
            {
                ContaPoupanca conta5 = (ContaPoupanca)conta3;
                conta5.AtualizarSaldo();
                Console.WriteLine("Saldo Atualizado!");
            }

            Console.Read();
        }
    }
}
