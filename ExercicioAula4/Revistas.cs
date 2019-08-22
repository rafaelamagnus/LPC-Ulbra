using System.Collections.Generic;

namespace teste
{
    public class Revistas: Materiais
    {
        public string colecao { get; set; }
        public string editora { get; set; }
        public List<Artigos> artigos { get; set; }

        public Revistas(int codigo, string assunto, string titulo,string colecao, string editora, List<Artigos> artigos) : base(codigo, assunto, titulo)
        {
            this.colecao = colecao;
            this.editora = editora;
            this.artigos = artigos;
        }

        public void MostrarDetalhes(){
            
        }

    }
}