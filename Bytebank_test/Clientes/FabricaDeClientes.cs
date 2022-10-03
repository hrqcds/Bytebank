using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_test.Clientes
{
    public class FabricaDeClientes
    {
        public static Cliente CriarCliente(string nome, string cpf)
        {
            return new Cliente(nome, cpf);
        }
    }
}
