using System.Collections.Generic;
using ToDoList.classes;

namespace ToDoList.interfaces
{
    public interface IImovelRepository
    {
        void Create(Imoveis Imoveis);
        void Update(Imoveis Imoveis);
        void Delete(int id);
        Imoveis GetById(int id);
        List<Imoveis> GetAll();
    }
}