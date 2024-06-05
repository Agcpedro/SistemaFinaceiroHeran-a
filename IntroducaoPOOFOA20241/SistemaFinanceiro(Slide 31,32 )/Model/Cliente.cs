using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    // Slide 26 Criação da Classe Cliente
    public class Cliente
    {
        private string _nome;
        private int _idade;
        private string _cpf;
        private string _email;
        private int _anoNascimento;

        public Cliente(string nome, int idade, string cpf)
        {
                _nome = nome;
                if (idade >= 18)
                {
                    _idade = idade;
                }
                else
                {
                    Console.WriteLine("Um cliente precisa ter 18 anos ou mais");
                    throw new ArgumentException("Um cliente precisa ter 18 anos ou mais.");
                }
                if (cpf.Length == 11)
                {
                    _cpf = cpf;
                }
                else
                {
                    Console.WriteLine("Entre com um cpf valido (Tamanho 11 , Apenas Numeros)");
                    throw new ArgumentException("Entre com um cpf valido (Tamanho 11 , Apenas Numeros)");
                }

        }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        public string Cpf
        {

            get => _cpf;
            set => _cpf = value;

        
        }
        public string Email
        {

            get => _email;
            set => _email = value;


        }
        public int AnoNascimento
        {

            get => _anoNascimento;
            set => _anoNascimento = value;


        }
    }
}
