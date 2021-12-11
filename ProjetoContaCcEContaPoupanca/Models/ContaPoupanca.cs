using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoContaCcEContaPoupanca.Models
{
    class ContaPoupanca
    {
        public decimal Saldo { get; set; }

        public string Numero { get; set; }

        public decimal Rendimentos { get; set; }

        public bool Depositar(decimal valorDeposito)
        {

            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                return true;
            }

            else
            {
                return false;
            }

        }
        public bool Retirar(decimal valorRetirada)
        {
            if(valorRetirada <= Saldo)
            {
                Saldo = -valorRetirada;
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
