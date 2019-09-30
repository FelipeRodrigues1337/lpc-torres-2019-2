using System.Collections.Generic;

namespace contasLuz.Models
{
    public interface IContaRepository
    {   
        void Create(Conta person);
        void Update(Conta person);
        void Delete(int id);
        Conta GetById(int id);
        List<Conta> GetAll();
    }
}