using System.Collections.Generic;
using ToDoList.interfaces;
using ToDoList.classes;

namespace ToDoList.MVC.ViewsModels
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(IContaLuzRepository contaLuzRepository)
        {
            this.listaContasLuz = contaLuzRepository.Get();
            this.menorConsumo = contaLuzRepository.GetMenorConsumo();
            this.maiorConsumo = contaLuzRepository.GetMaiorConsumo();
        }

        public IEnumerable<ContaLuz> listaContasLuz { get; set; }
        public ContaLuz menorConsumo { get; set; }
        public ContaLuz maiorConsumo { get; set; }
    }
}