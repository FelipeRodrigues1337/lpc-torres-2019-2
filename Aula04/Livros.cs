using System;

namespace Aula3
{
    public class Livros
    {
        private string editora{ get; set; }
        private string edicao{ get; set; }
        private string isbn{ get; set; }
        private string autor{ get; set; }

        public void MostraDetalhes(){
            Console.WriteLine(this.editora);
            Console.WriteLine(this.edicao);
            Console.WriteLine(this.isbn);
            Console.WriteLine(this.autor);
        }
    }
}