using SistemaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro_Slide_31_32__.Model
{
    internal class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero, decimal saldo, Cliente cliente, Agencia agencia) : base(numero, saldo, cliente, agencia)
        {
        }

        public override void Deposito(decimal valor)
        {
            if (valor >= 1)
            {
                Saldo += (valor + 1);
            }else
            {
                throw new ArgumentException("Não pode ser realisado depositos inferiores a 1,00");
            }
        }



        public virtual decimal Saque(decimal valor)
        {
            if (Saldo - (valor + 5) >= 0)
            {
                Saldo -= (valor + 5);
                return Saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }

    }
}
