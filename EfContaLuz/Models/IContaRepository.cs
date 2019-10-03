using System.Collections.Generic;

namespace EfContaLuz.Models
{
    public interface IContaRepository
    {
         void Create(Conta c);
          void Update(Conta c);
          void Delete(int id);

          Conta GetById(int id);
          List<Conta>Getall();

          Conta MaiorConsumo();
          Conta MenorConsumo();
    }
}