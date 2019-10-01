using System;
using System.Collections.Generic;
using System.Linq;

namespace ContaLuz.Models
{
    public class HomeRepository
    {
        public static int _autoIncrement = 1;
        public static int count = 0;
    
        public static List<Home> conta = new List<Home>();

        public HomeRepository(){}


        public void Create(Home c)
        {
            conta.Add(c);
        }
        public List<Home> GetAll()
        {
            return conta;
        }

        public Home GetById(int id)
        {
            return conta.Find(i=>i.id ==id);
        }
        public void Delete(int id)
        {
            conta.Remove(GetById(id));
        }
        public void Update(Home c)
        {
            var i = conta.FindIndex(x=>x.id == c.id);
            conta[i].nome = c.nome;
            conta[i].numLeitura = c.numLeitura;
            conta[i].kwGasto = c.kwGasto;
            conta[i].valorPagar = c.valorPagar;
            conta[i].dataPagamento = c.dataPagamento;
            conta[i].mediaConsumo= c.mediaConsumo;

        }
        
         public Home menosConsumo()
        {
             return conta.Find(cont => cont.kwGasto == conta.Min(contaa => contaa.kwGasto));
        }

        public Home maiorConsumo()
        {
            return conta.Find(cont => cont.kwGasto == conta.Max(contaa => contaa.kwGasto));
        }

    }
    
}