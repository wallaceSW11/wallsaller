using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> Insert(Customer entity);
        Task<bool> Update(Customer entity);
        bool Delete(int id);
        bool Exists(string id);
        bool ExistsIdentity(string identity);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetByName(string name);
        Task<Customer> GetById(int id);

    }
}