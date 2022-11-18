using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> Insert(Customer entity);
        bool Update(Customer entity);
        bool Delete(int id);
        bool Exists(int id);
        Task<List<Customer>> GetAll();
        Task<Customer> GetByName(string name);

    }
}