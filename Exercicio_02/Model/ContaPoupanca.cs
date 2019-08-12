using Exercicio_02.Banco.Model;
using Exercicio_02.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }

        private readonly decimal _rendimento;

        public ContaPoupanca(decimal rendimento) => _rendimento = rendimento;
        public ContaPoupanca() {}

        public decimal CalculaRetornoInvestimento()
        {
            return _rendimento * Saldo;
        }
        public override void Depositar(decimal value)
        {
            Saldo += value;
        }
        public override void Retirar(decimal value)
        {
            decimal total = value + Taxa;
            if (total > Saldo)
                throw new SaldoInsuficienteException();
            Saldo -= total;            
        }
    }
}
