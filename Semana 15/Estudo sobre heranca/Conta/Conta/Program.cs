using System;
using Conta.Entities;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaComercial conta = new ContaComercial(8010, "Jeh", 100.0, 500.0);

            Console.WriteLine(conta.Saldo);

            Console.Read();

        }
    }
}
