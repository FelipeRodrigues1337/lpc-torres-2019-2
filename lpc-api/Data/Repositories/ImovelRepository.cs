using System.Collections.Generic;
using System.Linq;
using Data.Data;
using Domain.Models;
using TESTE.Interfaces;

namespace Data.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        private ApplicationDbContext _context;
    
        public ImovelRepository(ApplicationDbContext context)
        {           
            this._context = context;
        }
        public int Insert(Imovel obj)
        {
            _context.imovel.Add(obj);
            _context.SaveChanges();
            return obj.id;
        }

        public int Update(Imovel obj)
        {
            var imovelMod = GetById(obj.id);
            imovelMod.bairro = obj.bairro;
            imovelMod.cidade = obj.cidade;
            imovelMod.estado = obj.estado;
            imovelMod.identificacao = obj.identificacao;
            imovelMod.numero = obj.numero;
            
            
            _context.SaveChanges();
            return imovelMod.id;
        }

        public int Delete(int id)
        {
            _context.imovel.Remove(GetById(id));
            _context.SaveChanges();
            return id;
        }

        public Imovel GetById(int id)
        {
            return _context.imovel.SingleOrDefault(c=>c.id ==id);
        }

        public List<Imovel> GetAll()
        {
            return _context.imovel.ToList();
        }
    }
}