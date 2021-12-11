using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoContaCcEContaPoupanca.Models
{
    class ContaCorrente
    {
        public decimal Saldo { get; set; }

        public string Numero { get; set; }

        public bool Especial { get; set; }

        public Cliente Cliente { get; set; }

        public ContaPoupanca ContaPoupanca { get; set; }

        public double Juros { get; set; }

        ContaPoupanca contaPoupanca = new ContaPoupanca();


        public bool Depositar(decimal valorDeposito)
        {
            if(valorDeposito > 0 )
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
                Saldo -= valorRetirada;
                return true;
            }

            else
            {
                return false;
            }
        }

      

        public bool TransferirParaPoupanca(decimal valorTransferencia)
        {
            if(valorTransferencia > 0 && valorTransferencia <= Saldo)
            {
                Saldo -= valorTransferencia;
                contaPoupanca.Saldo += valorTransferencia;
                return true;
            }

            else
            {
                return false;
            }
        }

        public decimal ExibirSaldoTotal()
        {
            Saldo += contaPoupanca.Saldo;
            return Saldo;
        }

    }
}
