using SistemaFinanceiro_Slide_31_32__.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class Operacao
    {
        public Operacao()
        {
        }

        //Slide 26 - Compara Saldo de 2 contas e retorna o numero da conta com o maior saldo
        public long CamparaMaiorSaldo(Conta conta1, Conta conta2)
        {
            decimal saldo1 = conta1.Saldo;
            decimal saldo2 = conta2.Saldo;

            decimal maiorsaldo = Math.Max(saldo1, saldo2);

            if (maiorsaldo == saldo1)
            {
                return conta1.Numero;
            }
            else
            {
                return conta2.Numero;
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

        public Cliente CriarCliente() 
        {
            Console.WriteLine("Digite o nome do Cliente:");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            int idadeCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o CPF:");
            string cpfCliente = Console.ReadLine();

            var cliente = new Cliente(nomeCliente, idadeCliente, cpfCliente);

            return cliente;
        }

        public Banco CriarBanco()
        {
            Console.WriteLine("Digite o numero do Banco:");
            int numeroBanco = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite o nome do Banco:");
            string nomeBanco = Console.ReadLine();


            Banco banco = new Banco(numeroBanco, nomeBanco);

            return banco;
        }

        public Agencia CriarAgencia(Banco banco)
        {
            Console.WriteLine("Digite o numero da Agencia:");
            int numeroAgencia = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a idade:");
            string nomeAgencia = Console.ReadLine();

            Console.WriteLine("Digite o Telefone:");
            string telefoneAgencia = Console.ReadLine();

            Console.WriteLine("Digite o CEP:");
            string cepAgencia = Console.ReadLine();

            var agencia = new Agencia(numeroAgencia, nomeAgencia, telefoneAgencia, cepAgencia, banco);

            return agencia;
        }

    }
}
