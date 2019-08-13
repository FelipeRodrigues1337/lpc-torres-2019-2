using System;
namespace aula02
{
    public class Agencia
    {
        private string nome;
        private string numero;

       public Agencia(string numero){
           this.numero = numero;
       }
       public void registrar(string nome, string numero){
        this.nome = nome;
        this.numero = numero;
        }
        public void getAll(){
            Console.WriteLine($"Nome agencia: {this.nome}");
            Console.WriteLine($"Numero agencia: {this.numero}");
        }
    }
}