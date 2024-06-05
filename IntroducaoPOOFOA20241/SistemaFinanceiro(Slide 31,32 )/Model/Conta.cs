using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;
        public Cliente _cliente;
        public Agencia _agencia;

        //Slide 31 - Conta so poderá ser criada com um cliente titular
        public Conta(long numero, decimal saldo, Cliente cliente, Agencia agencia) 
        {
            if (numero > 999)
            {
                _numero = numero;
            }
            else
            {
                Console.WriteLine("O numero da conta deve ser superior a 999.");

                throw new ArgumentException("O numero da conta deve ser superior a 999.");
            }

            if (saldo >= 11)
            {
                _saldo = saldo;
            }
            else
            {
                Console.WriteLine("O saldo deve ser superior a R$10 para criar uma conta.");
                
                throw new ArgumentException("O saldo deve ser superior a R$10 para criar uma conta.");
            }
            _cliente = cliente; //Isso ja deve dar um erro quando não colocada

            _agencia = agencia;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo 
        { get => _saldo; set
            {
                _saldo = value;
            }
        }

        public Cliente Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }

        public Agencia Agencia
        {
            get => _agencia;
            set => _agencia = value;
        }


        public virtual void Deposito(decimal valor)
        {
            _saldo += valor;
        }



        public virtual decimal Saque(decimal valor)
        {
            if(Saldo - valor >= 0)
            {
                Saldo -= (valor + 0.10m); //Slide 31 Banco agora cobra R$0,10
                return Saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }
        public virtual void Transferir(decimal valor, Conta contaPerde, Conta contaRecebe)
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
