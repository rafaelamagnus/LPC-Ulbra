using System.Collections.Generic;

namespace teste
{
    public class Materiais
    {
        public int codigo { get; private set; }
        public string assunto { get; private set; }
        public string titulo { get; private set; }
        public List<Reserva> reserva {get; private set;}

        public Materiais(int codigo, string assunto, string titulo)
        {
            this.codigo = codigo;
            this.assunto = assunto;
            this.titulo = titulo;
        }

        public bool Emprestar(){
            return true;
        }
        public void Devolver(){

        }
    }
}