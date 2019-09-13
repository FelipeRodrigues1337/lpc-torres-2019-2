using System;

namespace contasLuz.Models
{
    
    public class Conta
    {
        public Conta (){
           
        }

        public Conta(int numeroLeitura, DateTime dataLeitura, int kwGasto, double valorPagar, DateTime dataPagamento, double mediaConsumo)
        {
            this.numeroLeitura = numeroLeitura;
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorPagar = valorPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
                  
            
        }


        public int numeroLeitura { get; set; }
       public DateTime dataLeitura { get; set; }
       public int kwGasto { get; set; }
       public double valorPagar { get; set; }
       public DateTime dataPagamento { get; set; }
       public double mediaConsumo { get; set; }
        
    }

}