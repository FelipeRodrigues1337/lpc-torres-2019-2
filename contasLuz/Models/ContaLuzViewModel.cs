using System;
using System.Collections.Generic;
using contasLuz.Models;

namespace contasLuz.Models
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(ContaRepository _listaContaLuz)
        {
            
            this.listaContasLuz = _listaContaLuz.GetAllContaLuz();
            this.maiorConsumo = _listaContaLuz.maiorConsumo();
            this.menorConsumo = _listaContaLuz.menorConsumo();
        }

         public IEnumerable<Conta> listaContasLuz { get; set; }
        public Conta maiorConsumo { get; set; }

        public Conta menorConsumo { get; set; }

        public int teste(){
            return 0;
        }
    }
}