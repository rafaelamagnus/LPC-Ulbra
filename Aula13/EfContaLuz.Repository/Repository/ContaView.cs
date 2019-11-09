using System.Collections.Generic;

namespace EfContaLuz.Models
{
    public class ContaView
    {
          public ContaView(IContaRepository _lista)
        {
            this.lista = _lista.Getall();
            this.maiorConsumo= _lista.MaiorConsumo();
            this.menorConsumo= _lista.MenorConsumo();
        }
       public IEnumerable<Conta> lista { get; set; }
        public Conta maiorConsumo { get; set; }
        public Conta menorConsumo { get; set; }
    }
    }