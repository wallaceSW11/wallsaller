using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.domain.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Exists(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

    }
}