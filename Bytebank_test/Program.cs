using Bytebank_test.Clientes;
using Bytebank_test.Contas;

void Main()
{
    Cliente henrique = FabricaDeClientes.CriarCliente(nome: "Henrique", cpf: "123456789-00");
    Cliente pablo = FabricaDeClientes.CriarCliente(nome: "Pablo", cpf: "123453789-00");
    Conta contaDoHenrique = FabricaDeContas.CriarContaCorrente(henrique, 13.00);
    Conta contaDoPablo = FabricaDeContas.CriarContaCorrente(pablo, 3000.00);


    Console.WriteLine("Conta do Henrique");
    contaDoHenrique.Depositor(3000);
    contaDoHenrique.Sacar(127);
    Console.WriteLine(contaDoHenrique.ConferirSaldo());

    Console.WriteLine("==================================================");

    Console.WriteLine("Conta do Pablo");
    Console.WriteLine(contaDoPablo.ConferirSaldo());
}

Main();