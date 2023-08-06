using Car_E_shop.Models;

namespace Car_E_shop.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
