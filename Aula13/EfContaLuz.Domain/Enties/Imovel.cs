namespace EfContaLuz.Models
{
    public class Imovel
    {
        public Imovel(){}
        public Imovel(int id, int numero, string descricao, string cidade, string estado)
        {
            this.id = id;
            this.numero = numero;
            this.descricao = descricao;
            this.cidade = cidade;
            this.estado = estado;

        }
        public int id { get; set; }
        public int numero { get; set; }
        public string descricao { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        
    }
}