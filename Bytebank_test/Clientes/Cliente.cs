namespace Bytebank_test.Clientes
{
    public class Cliente
    {
       
        public string Nome { get; set; }

        public string Cpf { get; }
            
        public static int totalClientes{get; private set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            totalClientes++;
        }
    }
}
