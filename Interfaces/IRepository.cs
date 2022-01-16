using System.Collections.Generic;

namespace dio.series.Interfaces
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T ReturnById(int id);
         void Create(T entidade);
         void Update(int id, T entidade);
         void Delete(int id);
         int NextId();
    }
}