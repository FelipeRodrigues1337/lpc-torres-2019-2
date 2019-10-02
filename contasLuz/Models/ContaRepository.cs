using System.Collections.Generic;
using System;
using System.Linq;
namespace contasLuz.Models

{
    public class ContaRepository : IContaRepository
    {
        private DataContext context;
    
        public ContaRepository(DataContext context)
        {           
            this.context = context;
        }

        public void Create(Conta conta)
        {
            context.contaLuz.Add(conta);
            context.SaveChanges();
        }
        public List<Conta> GetAllContaLuz()
        {
            return context.contaLuz.ToList();
        }
        
        public Conta GetById(int id)
        {
            return context.contaLuz.SingleOrDefault(x=>x.id ==id);
        }
        public void Delete(int id)
        {
           context.contaLuz.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Conta conta)
        {
            var objContaLuz = GetById(conta.id);
            objContaLuz.numeroLeitura = conta.numeroLeitura;
            objContaLuz.dataLeitura = conta.dataLeitura;
            objContaLuz.kwGasto = conta.kwGasto;
            objContaLuz.valorPagar = conta.valorPagar;
            objContaLuz.dataPagamento = conta.dataPagamento;
            objContaLuz.mediaConsumo = conta.mediaConsumo;
             context.SaveChanges();
        }

     /* public Conta menorConsumo()
        {
            // contasLuz.OrderBy(cont => cont.kwGasto).First();
            // contasLuz.OrderByDescending(cont => cont.kwGasto).Last();
            return context.contaLuz.Find(cont => cont.kwGasto == contas.Min(conta => conta.kwGasto));
        }

        public Conta maiorConsumo()
        {
            // contasLuz.OrderBy(cont => cont.kwGasto).Last();
            // contasLuz.OrderByDescending(cont => cont.kwGasto).First();
            return contas.Find(cont => cont.kwGasto == contas.Max(conta => conta.kwGasto));
        }*/

        public List<Conta> GetAll()
        {    
         return context.contaLuz.ToList();
        }
    }
}
