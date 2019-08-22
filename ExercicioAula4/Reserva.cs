using System;
using System.Collections.Generic;

namespace teste
{
    public class Reserva
    {
        public DateTime dataReserva { get; set; }
        public DateTime dataValidade { get; set; }
        public List<Materiais> materiais { get; set; }

        public bool Criar(){
            return true;
        }
        public void Cancelar(){
            
        }
         
    }
}