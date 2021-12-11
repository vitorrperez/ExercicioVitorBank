using System;
using ProjetoContaCcEContaPoupanca.Models;

namespace ProjetoContaCcEContaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao VitorBank\n\n");

            Cliente cl1 = new Cliente();
            cl1.LerDadosCliente();

            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            int opcao;

            Console.Clear();

            do
            {
                
                

                Console.WriteLine("Digite o numero correspondente para as seguinte opções" +
                    "\n\n 1 - Depoistar\n 2 - Sacar/Retira\n 3- Transferir para poupança\n 4 - Mostrar Saldo total\n 0 - SAIR");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor que deseja depositar");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        cc.Depositar(valor);
                        Console.WriteLine($"Seu saldo na conta corrente é de:{cc.Saldo}" );
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor que deseja Retirar/Sacar");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.Retirar(valor);
                        Console.WriteLine($"Seu saldo na conta corrente é de:{cc.Saldo}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o valor que deseja transferir para poupança");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"Seu saldo na conta corrente é de{cc.Saldo}");
                        break;

                    case 4:

                        decimal saldototal = cc.ExibirSaldoTotal();
                        Console.WriteLine($"Seu saldo total é: {saldototal}");
                        break;

                }

                
                Console.ReadKey();
                Console.Clear();
            }
            while(opcao != 0);

        }
    }
}
