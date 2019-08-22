namespace teste
{

    public class Livros: Materiais
    {
        public string editora { get; set; }
        public string edicao { get; set; }
        public string ISBN { get; set; }
        public string autor { get; set; }

        public Livros(int codigo, string assunto, string titulo, string editora, string edicao, string iSBN, string autor) : base(codigo, assunto,titulo)
        {
            this.editora = editora;
            this.edicao = edicao;
            this.ISBN = iSBN;
            this.autor = autor;
        }

        public void MostrarDetalhes(){

        }

    }
}