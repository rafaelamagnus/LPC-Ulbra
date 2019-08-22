using System;

namespace teste
{
    public class Emprestimo
    {
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataRetorno { get; set; }
        public DateTime atraso { get; set; }

        public bool Novo(){
            return true;
        }
    }
}