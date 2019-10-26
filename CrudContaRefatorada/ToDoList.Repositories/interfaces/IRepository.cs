using System.Collections.Generic;
using ToDoList.classes;

namespace ToDoList.interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}