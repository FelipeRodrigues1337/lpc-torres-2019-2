using System.Collections.Generic;
using ToDoList.classes;

namespace ToDoList.interfaces
{
    public interface IContaLuzRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}