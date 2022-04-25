using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _17_Exercicio
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria (int numero, string titular)
        {
            NumeroDaConta = numero;
            Titular = titular;
        }

        public ContaBancaria (int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
