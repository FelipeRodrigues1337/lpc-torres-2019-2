using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
        //Clientes
        Cliente cliente = new Cliente();
        Cliente cliente1 = new Cliente();
        //Cartões de credito
         CartaoCredito cartao = new CartaoCredito();
         CartaoCredito cartao1 = new CartaoCredito();
         //cartao 0
         Console.WriteLine("---------CARTAO 0--------");
         cartao.registrarCartao("20","1293193123","234","Roberto Carlos");
         cartao.compra(200);
         cartao.gerarFatura();
        //cartao 1
         Console.WriteLine("---------CARTAO 1--------");
         cartao1.registrarCartao("14","145234132","244","Gustavo Guanabara");
         cartao1.compra(1200);
         cartao1.gerarFatura();
         //Agencia
        Agencia agencia = new Agencia(null);
         Agencia agencia2 = new Agencia(null);
         Console.WriteLine("---------Agencia 1--------");
         agencia.registrar("Banrisul","1337");
         agencia.getAll();
         Console.WriteLine("---------Agencia 2--------");
         agencia2.registrar("Santander","7777");
         agencia2.getAll();
        //Conta
        Conta conta1 = new Conta(null);
        conta1.setLimite(200);
        conta1.setNumero(1231231);
        conta1.setSaldo(1000);
        conta1.setTitular("Ramon");
        Console.WriteLine("---------Conta 1--------");
        conta1.getAll();
        Conta conta2 = new Conta(null);
       
        conta2.setNumero(1341234);
        conta2.setSaldo(2000);
        conta2.setTitular("Luiz");
        Console.WriteLine("---------Conta 2--------");
        conta2.getAll();
        }
    }
}
