using Bytebank_test.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_test.Contas
{
    public class Conta
    {
        public Cliente Titular { get; private set; }

        public string NomeDaConta { get; private set; }

        public string NumeroDaConta { get; private set; }

        public double Saldo { get; private set; }

        public static int TotalDeContas { get; private set; }

        private static double Taxa { get; set; }

        public Conta(Cliente titular, string nomeDaConta, string numeroDaConta, double saldo)
        {
            this.Titular = titular;
            this.NomeDaConta = nomeDaConta;
            this.NumeroDaConta = numeroDaConta;
            this.Saldo = saldo;
            Taxa = TotalDeContas > 0 ? 30 / TotalDeContas++ : 30;
            TotalDeContas++;
        }

        public virtual double ConferirSaldo()
        {
            return Saldo;
        }

        public void Depositor(double value)
        {
            if (value <= 0) return;

            Saldo += value;
            Console.WriteLine($"Saldo de R$ {(double)value} depositado com sucesso");
        }

        public void Sacar(double value)
        {
            if (value <= 0) return;

            Saldo += value;
            Console.WriteLine($"Saldo de R$ {(double)value} retirado com sucesso");
        }

        public void Transferir(Conta conta, double value)
        {
            this.Sacar(value);
            conta.Depositor(value);
            Console.WriteLine($"Saldo de R$ {(double) value} transferido com sucesso");

        }

    }
}
