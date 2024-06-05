using SistemaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro_Slide_31_32__.Model
{
    internal class ContaEspecial : Conta
    {
        protected double _limite;
        public ContaEspecial(long numero, decimal saldo, Cliente cliente, Agencia agencia) : base(numero, saldo, cliente, agencia)
        {
        }

        public double Limite
        {
            get => _limite;
            set => _limite = value;
        }
        public override decimal Saque(decimal valor)
        {
            if (Saldo - valor >= 0)
            {
                Saldo -= valor ; //Não cobra 0,10 reais porque é uma conta especial
                return Saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }
        public void Transferir(decimal valor, Conta contaPerde, Conta contaRecebe)
        {
            if (contaPerde.Saldo - valor >= 0)
            {
                contaPerde.Saldo -= valor;
                contaRecebe.Saldo += valor;
            }
            else
            {
                throw new ArgumentException("Valor da tranferencia ultrapassa o saldo");
            }

            Console.WriteLine($"O valor Atual da Conta de {contaPerde.Cliente.Nome} é {contaPerde.Saldo}");
            Console.WriteLine($"O valor Atual da Conta de {contaRecebe.Cliente.Nome} é {contaRecebe.Saldo}");
        }
    }
}
