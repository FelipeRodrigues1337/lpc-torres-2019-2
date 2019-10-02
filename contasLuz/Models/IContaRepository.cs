using System.Collections.Generic;

namespace contasLuz.Models
{
    public interface IContaRepository
    {   
        void Create(Conta conta);
        void Update(Conta conta);
        void Delete(int id);
        Conta GetById(int id);
        List<Conta> GetAll();
    }
}