// See https://aka.ms/new-console-template for more information
using SistemaFinanceiro.Model;
using SistemaFinanceiro_Slide_31_32__.Model;

//Teste simples das contas diferentes

Banco banco = new Banco(1000,"Bancão");

Cliente cliente1 = new Cliente("João",18, "71921039000");
Cliente cliente2 = new Cliente("Maria", 20, "71921039000");
Agencia agencia = new Agencia(1000,"Agência Central","123456780","523727298-29",banco);

ContaEspecial contaEspecial = new ContaEspecial(1003, 100m, cliente1, agencia);
ContaCaixinha contaCaixinha = new ContaCaixinha(1002, 50m, cliente2, agencia);


Console.WriteLine("\nTeste conta especial (João):");

Console.WriteLine($"Saldo inicial de {contaEspecial.Cliente.Nome}: R${contaEspecial.Saldo}");
contaEspecial.Deposito(20m);
Console.WriteLine($"Saldo após depósito de R$20: R${contaEspecial.Saldo}");
contaEspecial.Saque(10m);
Console.WriteLine($"Saldo após saque de R$10: R${contaEspecial.Saldo}");

Console.WriteLine("\nTeste conta caixinha (Maria):");

Console.WriteLine($"\nSaldo inicial de {contaCaixinha.Cliente.Nome}: R${contaCaixinha.Saldo}");
contaCaixinha.Deposito(5m);
Console.WriteLine($"Saldo após depósito de R$5: R${contaCaixinha.Saldo}");
contaCaixinha.Saque(10m);
Console.WriteLine($"Saldo após saque de R$10: R${contaCaixinha.Saldo}");

Console.WriteLine($"\nSaldo inicial de {contaEspecial.Cliente.Nome}: R${contaEspecial.Saldo}");
contaEspecial.Deposito(50m);
Console.WriteLine($"Saldo após depósito de R$50: R${contaEspecial.Saldo}");
Console.WriteLine($"Teste de erro de saque R$200:");
try
{
    contaEspecial.Saque(200m);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao sacar: {ex.Message}");
}

Console.WriteLine("\nTransferência de R$30 de João para Maria");
contaEspecial.Transferir(30m, contaEspecial, contaCaixinha);

















