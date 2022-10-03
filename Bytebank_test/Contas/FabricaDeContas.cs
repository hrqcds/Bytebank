using Bytebank_test.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_test.Contas
{
    internal class FabricaDeContas
    {
        public static Conta CriarContaCorrente(Cliente titular, double saldo)
        {
            return new Conta(titular, "Conta corrente", "1235-x", saldo);
        }
    }
}
