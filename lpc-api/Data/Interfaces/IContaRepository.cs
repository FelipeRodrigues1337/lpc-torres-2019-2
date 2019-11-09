using System.Collections.Generic;
using Domain.Models;

namespace TESTE.Interfaces
{
    public interface IContaRepository
    {   
        int Insert(Conta conta);
        int Update(Conta conta);
        int Delete(int id);
        Conta GetById(int id);
        List<Conta> GetAll();
    }
}