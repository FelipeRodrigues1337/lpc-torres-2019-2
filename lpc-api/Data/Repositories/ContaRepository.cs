using System.Collections.Generic;
using System.Linq;
using Data.Data;
using TESTE.Interfaces;
using Domain.Models;

namespace TESTE.Repositories
{
    public class ContaRepository: IContaRepository
    {
        private ApplicationDbContext _context;
    
        public ContaRepository(ApplicationDbContext context)
        {           
            this._context = context;
        }

        public int Insert(Conta conta)
        {
            _context.Conta.Add(conta);
            _context.SaveChanges();
            return conta.id;
        }
        public List<Conta> GetAllContaLuz()
        {
            return _context.Conta.ToList();
        }
        
        public Conta GetById(int id)
        {
            return _context.Conta.SingleOrDefault(c=>c.id ==id);
        }
        public int Delete(int id)
        {
            _context.Conta.Remove(GetById(id));
            _context.SaveChanges();
            return id;
        }

        public int Update(Conta conta)
        {
            var ContaMod = GetById(conta.id);
            ContaMod.leitura = conta.leitura;
            ContaMod.dataLeitura = conta.dataLeitura;
            ContaMod.dataPagto = conta.dataPagto;
            ContaMod.kwGasto = conta.kwGasto;
            ContaMod.valor = conta.valor;
            ContaMod.media = conta.media;
            
            _context.SaveChanges();
            return ContaMod.id;
        }


        public List<Conta> GetAll()
        {    
            return _context.Conta.ToList();
        }
    }
}