using System;

namespace ToDoList.classes
{
    public class Imoveis
    {
        public Imoveis() { }

        public Imoveis(int id, string identificação, string numero, string bairro, string cidade, string estado)
        {
            this.id = id;
            this.identificação = identificação;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        public int id { get; set; }
        
        public string identificação { get; set; }

        public string numero { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }
    }
}