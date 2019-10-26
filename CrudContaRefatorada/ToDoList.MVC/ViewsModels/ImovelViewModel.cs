using System.Collections.Generic;
using ToDoList.classes;
using ToDoList.Repositories.repositories;

namespace ToDoList.MVC.ViewsModels
{
    public class ImovelViewModel
    {
        public ImovelViewModel(ImovelRepository imovelRepository)
        {
            this.listaImovel = imovelRepository.Get();
        }
        public IEnumerable<Imoveis> listaImovel { get; set; }
    }
}