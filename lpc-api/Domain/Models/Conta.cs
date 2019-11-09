using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Conta
    {
        [Key]
        public int id { get; set; }
        public DateTime dataLeitura { get; set; }
        public DateTime dataPagto { get; set; }
        public double kwGasto { get; set; }
        public int leitura { get; set; }
        public double valor { get; set; }
        public double media { get; set; }
        
        public int idImovel { get; set; }
        
        public Imovel imovel { get; set; }
    }
}