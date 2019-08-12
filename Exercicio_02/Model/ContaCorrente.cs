using Exercicio_02.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02.Banco.Model
{    
    // sealed -> 
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo;

        public ContaCorrente() {}

        public override void Depositar(decimal value)
        {
            Saldo += value;
        }

        public override void Retirar(decimal value)
        {
            if (Tipo == TipoConta.Comum && value > Saldo)
                throw new SaldoInsuficienteException();
            Saldo -= value;
        }
    }
}
