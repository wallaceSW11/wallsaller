using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<bool> Insert(Customer entity);
        bool Update(Customer entity);
        bool Delete(int id);
        bool Exists(int id);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetByName(string name);
        Task<Customer> GetById(int id);

    }
}