using System;

namespace aula02
{
    public class CartaoCredito
    {
        private decimal limite;
        private string vencimento;
        private decimal valorFatura;
        private string numero;
        private string cvv;
        private string nomePropretario;

        public void registrarCartao(string vencimento, string numero, string cvv, string nomePropretario){
        this.limite = 1000;
        this.vencimento = vencimento;
        this.numero = numero;
        this.cvv = cvv;
        this.nomePropretario = nomePropretario; 
    }
      public void compra(decimal valor){
          if(valor <= this.limite){
              this.limite=limite-valor;
              this.valorFatura = valorFatura+valor;
             Console.WriteLine("Compra aceita!");
          }else{
              Console.WriteLine("Compra negada!");
          }
      }

      public void dataVencimento(string data){
          this.vencimento=data;
      }  

      public void gerarFatura(){
          Console.WriteLine($"Valor a ser pago: {this.valorFatura}");
      }
    
    }
}