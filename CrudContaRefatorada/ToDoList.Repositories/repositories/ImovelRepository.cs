using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.data;
using ToDoList.classes;
using ToDoList.interfaces;

namespace ToDoList.Repositories.repositories
{
    public class ImovelRepository : IImovelRepository
    {
        private DataContext context;
    
        public ImovelRepository(DataContext context)
        {           
            this.context = context;
        }

        public void Create(Imoveis imoveis)
        {
            context.ImovelDb.Add(imoveis);
            context.SaveChanges();
        }
        public List<Imoveis> GetAllContaLuz()
        {
            return context.ImovelDb.ToList();
        }
        
        public Imoveis GetById(int id)
        {
            return context.ImovelDb.SingleOrDefault(x=>x.id ==id);
        }

        public Imoveis Get(int id)
        {
            return context.ImovelDb.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<Imoveis> Get()
        {
            return context.ImovelDb.ToList().OrderBy(x => x.id);
        }

        public void Delete(int id)
        {
            context.ImovelDb.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Imoveis imoveis)
        {
            var objImoveis = GetById(imoveis.id);
            objImoveis.identificação = imoveis.identificação;
            objImoveis.numero = imoveis.numero;
            objImoveis.bairro = imoveis.bairro;
            objImoveis.cidade = imoveis.cidade;
            objImoveis.estado = imoveis.estado;
            
            context.SaveChanges();
        }

        public List<Imoveis> GetAll()
        {    
         return context.ImovelDb.ToList();
        }
    }
}