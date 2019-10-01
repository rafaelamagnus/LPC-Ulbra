using System.Collections.Generic;

namespace ContaLuz.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(HomeRepository _lista)
        {
            this.lista = _lista.GetAll();
            this.maiorConsumo= _lista.maiorConsumo();
            this.menosConsumo= _lista.menosConsumo();



        }
       public IEnumerable<Home> lista { get; set; }
        public Home maiorConsumo { get; set; }
        public Home menosConsumo { get; set; }
    }
}