using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<bool> Insert(Client entity);
        bool Update(Client entity);
        bool Delete(int id);
        bool Exists(int id);
        Task<List<Client>> GetAll();
        Task<Client> GetByName(string name);

    }
}