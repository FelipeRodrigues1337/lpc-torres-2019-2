using System;

namespace aula02
{
    class Conta
    {
        private int numero;
        private string titular;
        private decimal saldo;
        private decimal limite;

        private string referencia;

         public Conta(string referencia){
            this.limite = 100;
            this.referencia = referencia;
        }

        public void deposito(decimal valor){
            this.saldo = this.saldo+valor;
        }
        
        public void saque(decimal valor){
            if(valor<=this.saldo){
                this.saldo=this.saldo-valor;
                Console.WriteLine("Operação concluida!");
            }else{
                Console.WriteLine("Operação negada!");
            }
        }

        public void transferencia(decimal valor){
             if(valor<=this.saldo){
                this.saldo=this.saldo-valor;
                Console.WriteLine("Operação concluida!");
            }else{
                Console.WriteLine("Operação negada!");
            }
        }

        public void consulta(){
            Console.WriteLine($"Saldo disponivel: {this.saldo}");
        }
        public void setNumero(int numero){
            this.numero = numero;
        }
        public void getNumero(){
            Console.WriteLine($"Numero: {this.numero}");
        }

        public void setTitular(string titular){
            this.titular = titular;
        }

        public void getTitular(){
            Console.WriteLine($"Titular: {this.titular}");
        }

        public void setSaldo(decimal saldo){
            this.saldo = saldo;
        }

        public void getSaldo(){
            Console.WriteLine($"Saldo: {this.saldo}");
        }

        public void setLimite(decimal limite){
            this.limite = limite;
        }

        public void getLimite(){
            Console.WriteLine($"Limite: {this.limite}");
        }

        public void getAll(){
            Console.WriteLine($"Numero: {this.numero}");
            Console.WriteLine($"Titular: {this.titular}");
            Console.WriteLine($"Saldo: {this.saldo}");
            Console.WriteLine($"Limite: {this.limite}");
        }

    }
}
