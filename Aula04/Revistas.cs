using System;

namespace Aula3
{
    public class Revistas
    {
        private string Coleção{ get; set; }
        private string Editora{ get; set; }
        private Artigos artigos = new Artigos();

        public void MostraDetalhes(){
            Console.WriteLine(this.Coleção);
            Console.WriteLine(this.Editora);
            Console.WriteLine(this.artigos);
        }
    }
}