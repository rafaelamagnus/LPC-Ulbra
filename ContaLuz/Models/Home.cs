using System;

namespace ContaLuz.Models
{
    public class Home
    {
     public Home(){}

        public Home(int id, string nome, int numLeitura, int kwGasto, decimal valorPagar, DateTime dataPagamento, decimal mediaConsumo)
        {
            this.id = id;
            this.nome = nome;
            this.numLeitura = numLeitura;
            this.kwGasto = kwGasto;
            this.valorPagar = valorPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
            
        }

        public int id { get; set; }
        public string nome { get; set; }
        public int numLeitura { get; set; }
        public int kwGasto { get; set; }
        public decimal valorPagar { get; set; }
        public DateTime dataPagamento { get; set; }
        public decimal mediaConsumo { get; set; }
    
    }
}