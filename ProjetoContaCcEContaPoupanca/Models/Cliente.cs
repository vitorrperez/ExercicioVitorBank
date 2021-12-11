using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoContaCcEContaPoupanca.Models
{
    class Cliente
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }


        public void LerDadosCliente()
        {
            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF");
            Cpf = Console.ReadLine();

            Console.WriteLine("Digite seu Telefone");
            Telefone = Console.ReadLine();
        }

        public void ExibirDadosCadastraisCliente()
        {
            Console.WriteLine($"Cliente {Nome}, portador do CPF: {Cpf}, com telefone: {Telefone} ");
        }

    }
}



