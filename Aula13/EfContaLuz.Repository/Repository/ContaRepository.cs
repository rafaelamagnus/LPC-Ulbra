using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EfContaLuz.Models
{
    public class ContaRepository : IContaRepository
    {
       private DataContext context;
       public ContaRepository(DataContext context)
       {
           this.context=context;
       }
        public void Create(Conta c)
        {
        context.account.Add(c);
        context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.account.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Conta> Getall()
        {
            
            return context.account.Include(x=>x.imovel).ToList();
        }

        public Conta GetById(int id)
        {
           return context.account.SingleOrDefault(x=>x.id ==id );
        }

        public Conta MaiorConsumo()
        {
            var contas = Getall();
            return contas.Find(cont => cont.kwGasto == contas.Max(contaa => contaa.kwGasto));
        }

        public Conta MenorConsumo()
        {
           var contas = Getall();
            return contas.Find(cont => cont.kwGasto == contas.Min(contaa => contaa.kwGasto));
        }

        public void Update(Conta c)
        {
            var objConta = GetById(c.id);
            objConta.nome = c.nome;
            objConta.numLeitura=c.numLeitura;
            objConta.kwGasto = c.kwGasto;
            objConta.valorPagar = c.valorPagar;
            objConta.dataPagamento = c.dataPagamento;
            objConta.mediaConsumo = c.mediaConsumo;

            context.SaveChanges();
        }
        
    }
}