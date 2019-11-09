using System.Collections.Generic;

namespace EfContaLuz.Models
{
    public interface IBaseRepository<Entity>
    where Entity : class
    {
        void Create(Entity entity);
          void Update(Entity entity);
          void Delete(int id);

          Entity GetById(int id);
          List<Entity>Getall();

          Entity MaiorConsumo();
          Entity MenorConsumo();
    }
}