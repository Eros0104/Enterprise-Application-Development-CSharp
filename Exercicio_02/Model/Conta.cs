using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02.Banco.Model
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal value); 
        public abstract void Retirar(decimal value);
    }
}
