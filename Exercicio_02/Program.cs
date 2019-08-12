using Exercicio_02.Banco.Model;
using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poupanca = new ContaPoupanca(10);
            poupanca.Saldo = 10000;
            poupanca.Taxa = 5;

            poupanca.Depositar(1000);
            Console.WriteLine("Depositar - Saldo atual: " + poupanca.Saldo);

            poupanca.Retirar(1000);
            Console.WriteLine("Retirada - Saldo atual: " + poupanca.Saldo);

            Console.WriteLine(
                "Retorno Investimento: " +
                poupanca.CalculaRetornoInvestimento()
                );

            try
            {
                poupanca.Retirar(1000000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ContaCorrente corrente = new ContaCorrente();
        }
    }
}
