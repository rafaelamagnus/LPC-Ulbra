using System.Collections.Generic;

namespace teste
{
    public class Artigos
    {
        public string autor { get; set; }
        public string tituloArtigo { get; set; }
        public Revistas revista { get; set; }

        public Artigos(string autor, string tituloArtigo, Revistas revista)
        {
            this.autor = autor;
            this.tituloArtigo = tituloArtigo;
            this.revista = revista;
        }
    }
}