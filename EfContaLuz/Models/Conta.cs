using System;

namespace EfContaLuz.Models
{
    public class Conta
    {

        public Conta(){}

        public Conta(int id, string nome, int numLeitura, decimal kwGasto, decimal valorPagar, DateTime dataPagamento,int mediaConsumo)
        {
            this.id = id;
            this.nome = nome;
            this.numLeitura=numLeitura;
            this.kwGasto=kwGasto;
            this.valorPagar=valorPagar;
            this.dataPagamento=dataPagamento;
            this.mediaConsumo=mediaConsumo;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public int numLeitura { get; set; }
        public decimal kwGasto { get; set; }
        public decimal valorPagar { get; set; }
        public DateTime dataPagamento { get; set; }
        public int mediaConsumo { get; set; }
    }
}